using Application.Contracts;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ServiceCreator<TInstance> : IServiceCreator<TInstance> where TInstance : class
    {
        public TInstance GetInstance(string assemblyName, string interfaceName, string className)
        {
            throw new NotImplementedException();
        }
    }
}
