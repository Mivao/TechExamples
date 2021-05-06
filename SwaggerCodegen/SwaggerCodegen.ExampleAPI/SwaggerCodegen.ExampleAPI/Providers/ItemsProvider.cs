using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SwaggerCodegen.ExampleAPI.Db;
using SwaggerCodegen.ExampleAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerCodegen.ExampleAPI.Providers
{
    public class ItemsProvider : IItemsProvider
    {
        private readonly ItemsDbContext _dbContext;
        private readonly ILogger<ItemsProvider> _logger;

        public ItemsProvider(ItemsDbContext dbContext, ILogger<ItemsProvider> logger)
        {
            this._dbContext = dbContext;
            this._logger = logger;
        }

        public async Task<(bool IsSuccess, string ErrorMessage)> deleteAsync(int Id)
        {
            try
            {
                var item = await _dbContext.Items.SingleOrDefaultAsync(foo => foo.Id == Id);

                if(item != null)
                {
                    _dbContext.Items.Remove(item);
                    await _dbContext.SaveChangesAsync();
                    return (true, null);
                }
                return (false, $"Item with id: {Id} not found");
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex.ToString());
                return (false, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, Item Item, string ErrorMessage)> getAsync(int Id)
        {
            try
            {
                var item = await _dbContext.Items.SingleOrDefaultAsync(foo => foo.Id == Id);

                if (item != null)
                {
                    return (true, item, null);
                }
                return (false, null, $"Item with id: {Id} not found");
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex.ToString());
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, Item Item, string ErrorMessage)> postAsync(Item Item)
        {
            try
            {
                var result = await _dbContext.Items.AddAsync(Item);
                await _dbContext.SaveChangesAsync();
                return (true, result.Entity, null);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex.ToString());
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, string ErrorMessage)> updateAsync(Item Item)
        {
            try
            {
                _dbContext.Items.Update(Item);
                await _dbContext.SaveChangesAsync();
                return (true, null);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex.ToString());
                return (false, ex.Message);
            }
        }
    }
}
