using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjectionLifetimesExample.Service.SubService
{
    public class ScopedSubService
    {
        private readonly ScopedService _scopedService;
        public ScopedSubService(ScopedService scopedService)
        {
            _scopedService = scopedService;
        }

        public string GetValue()
        {
            return _scopedService.GetValue();
        }
    }
}
