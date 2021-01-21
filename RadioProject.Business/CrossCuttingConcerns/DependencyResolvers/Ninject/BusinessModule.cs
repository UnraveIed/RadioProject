using Ninject.Modules;
using RadioProject.Business.Abstract;
using RadioProject.Business.Concrete;
using RadioProject.DataAccess.Abstract;
using RadioProject.DataAccess.Concrete.ADONET;
using RadioProject.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioProject.Business.CrossCuttingConcerns.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRadioService>().To<RadioManager>().InSingletonScope();
            Bind<IRadioDal>().To<ADORadioDal>().InSingletonScope();

            Bind<IPostService>().To<PostManager>().InSingletonScope();
            Bind<IPostDal>().To<ADOPostDal>().InSingletonScope();
        }
    }
}
