using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface IServiceCreator<TInstance> where TInstance : class
    {
        TInstance GetInstance(string assemblyName, string interfaceName, string className);
    }
}
