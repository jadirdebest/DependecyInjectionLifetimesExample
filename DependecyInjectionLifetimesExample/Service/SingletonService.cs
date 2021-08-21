using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjectionLifetimesExample.Service
{
    public class SingletonService
    {
        private string Value { get; set; } = Guid.NewGuid().ToString();

        public string GetValue()
        {
            return Value;
        }
    }
}
