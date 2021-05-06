using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacExample.API.Interfaces
{
    /// <summary>
    /// Defines a service that may need to be injected into a controller e.g. to handle requests to other APIs.
    /// </summary>
    public interface IExampleService
    {
        public void ExampleServiceMethod();
    }
}
