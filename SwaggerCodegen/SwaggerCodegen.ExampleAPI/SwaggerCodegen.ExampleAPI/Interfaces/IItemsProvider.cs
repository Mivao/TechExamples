using SwaggerCodegen.ExampleAPI.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerCodegen.ExampleAPI.Interfaces
{
    public interface IItemsProvider
    {
        Task<(bool IsSuccess, Item Item, string ErrorMessage)> getAsync(int Id);

        Task<(bool IsSuccess, Item Item, string ErrorMessage)> postAsync(Item Item);

        Task<(bool IsSuccess, string ErrorMessage)> updateAsync(Item Item);

        Task<(bool IsSuccess, string ErrorMessage)> deleteAsync(int Id);
    }
}
