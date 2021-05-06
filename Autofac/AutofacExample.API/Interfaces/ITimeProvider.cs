using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacExample.API.Interfaces
{
    public interface ITimeProvider
    {
        public string GetTimestamp();        
    }
}
