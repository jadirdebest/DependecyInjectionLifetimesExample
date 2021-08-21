using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjectionLifetimesExample.Service.SubService
{
    public class TransientSubService
    {
        private readonly TransientService _transientService;
        public TransientSubService(TransientService transienService)
        {
            _transientService = transienService;
        }

        public string GetValue()
        {
            return _transientService.GetValue();
        }
    }
}
