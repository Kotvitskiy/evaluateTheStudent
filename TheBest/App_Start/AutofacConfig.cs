using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac.Util;
using Autofac.Integration.Mvc;
using Business.ProviderDefinition;
using TheBest.EntityProviders.Providers;
using System.Web.Mvc;

namespace TheBest.App_Start
{
    public static class AutofacConfig
    {
        public static void Configurate()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            Load(builder);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentsDataProvider>().As<IStudentsDataProvider>();           
        }
    }
}