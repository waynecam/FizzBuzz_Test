using Application.Contracts;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ServiceCreator<TInstance> : IServiceCreator<TInstance> where TInstance : class
    {
        public TInstance? GetInstance(string assemblyName, string interfaceName, string className)
        {
            Assembly ass = Assembly.LoadFrom(assemblyName);

            TInstance? result = new NullFBService() as TInstance;


            var type = ass.GetTypes().Where(type =>
            type.FullName == className
            && !type.IsAbstract
            && type.IsClass
            && type.GetInterface(interfaceName) != null)
             .Select(t => t).FirstOrDefault();


            if(type != null) 
                result = Activator.CreateInstance(type) as TInstance;
            

            return result;
        }
    }
}
