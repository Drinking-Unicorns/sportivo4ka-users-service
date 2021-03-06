using Autofac;
using AutoMapper;
using Divergic.Configuration.Autofac;
using Sportivo4ka.Users.API.Configurations.AutoMapper;
using Sportivo4ka.Users.BI.Options;
using System;

namespace Sportivo4ka.Users.API.Configurations.Autofac
{
    public class ServiceModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            //    builder.RegisterType<Class>()
            //        .As<Interface>();

            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            }
            )).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();

            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var resolver = new EnvironmentJsonResolver<Config>("appsettings.json", $"appsettings.{env}.json");
            var module = new ConfigurationModule(resolver);

            builder.RegisterModule(module);
        }
    }
}
