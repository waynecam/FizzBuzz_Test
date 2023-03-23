using Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp.App
{
    public class App : IApp
    {
        IServiceCreator<IFBService> _serviceCreator;

        public App(IServiceCreator<IFBService> serviceCreator)
        {
            _serviceCreator = serviceCreator;
        }
        public void Run(string[] args)
        {
            var instance = _serviceCreator.GetInstance("Infrastructure.dll",
                "Application.Contracts.IFBService",
                "Infrastructure.Services.FBService");

            if (instance != null)
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(instance.CalculateFizzBuzzResult(i));
                }
            }

        }
    }
}
