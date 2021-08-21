using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjectionLifetimesExample.Service.SubService
{
    public class SingletonSubService
    {
        private readonly SingletonService _singletonService;
        public SingletonSubService(SingletonService singletonService)
        {
            _singletonService = singletonService;
        }

        public string GetValue()
        {
            return _singletonService.GetValue();
        }
    }
}
