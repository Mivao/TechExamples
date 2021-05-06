using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacExample.API.Interfaces
{
    /// <summary>
    /// Defines a provider that may need to be injected into various controllers to handle HTTP requests.
    /// </summary>
    public interface IExampleProvider
    {
        public void ExampleProviderMethod();
    }
}
