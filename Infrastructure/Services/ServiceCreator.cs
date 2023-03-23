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
    public class ServiceCreator<TClass> : IServiceCreator<TClass> where TClass : class
    {

    }
}
