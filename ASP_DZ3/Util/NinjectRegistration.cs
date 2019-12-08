using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_DZ3.Models;

namespace ASP_DZ3.Util
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Account>>().To<DefaultRepository<Account>>().InSingletonScope();
        }
    }
}