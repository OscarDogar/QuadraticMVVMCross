using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Quadratic.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quadratic.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<QuadraticViewModel>();
        }
    }
}
