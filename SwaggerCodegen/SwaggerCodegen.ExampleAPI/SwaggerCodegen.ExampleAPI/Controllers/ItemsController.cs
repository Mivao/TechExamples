using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerCodegen.ExampleAPI.Db;
using SwaggerCodegen.ExampleAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwaggerCodegen.ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsProvider _provider;

        public ItemsController(IItemsProvider provider)
        {
            this._provider = provider;
        }

        /// <summary>
        /// Gets an Item based on a supplied Id.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(Item), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> getAsync(int Id)
        {
            var result = await _provider.getAsync(Id);
            if (result.IsSuccess)
            {
                return Ok(result.Item);
            }
            return NotFound(result.ErrorMessage);
        }

        /// <summary>
        /// Adds a new Item to the database
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(Item), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> postAsync(Item Item)
        {
            var result = await _provider.postAsync(Item);
            if (result.IsSuccess)
            {
                return Created($"/api/Items/{Item.Id}", Item);
            }
            return BadRequest();
        }

        /// <summary>
        /// Updates an existing Item
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> updateAsync(Item Item)
        {
            var result = await _provider.updateAsync(Item);
            if (result.IsSuccess)
            {
                return Ok();
            }
            return BadRequest();
        }

        /// <summary>
        /// Deletes an item from the database
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete("{Id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> deleteAsync(int Id)
        {
            var result = await _provider.deleteAsync(Id);
            if (result.IsSuccess)
            {
                return NoContent();
            }
            return NotFound();
        }

    }
}
