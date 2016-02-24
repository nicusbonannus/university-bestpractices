using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Reflection;
using System.Web.Mvc;
using UTN.Data.Infraestructure;
using UTN.Data.Repositories;
using UTN.Service.Services;

namespace UTN.Web.App_Start
{
    public class Bootstrapper
    {
        public static object DependecyResolver { get; private set; }

        public static void Run() {
            SetAutofacContainer();
        }

        private static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(StudentRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(StudentService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerRequest();

            IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}