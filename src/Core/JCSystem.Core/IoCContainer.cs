using System;
using Castle.MicroKernel;
using Castle.Windsor;
using JCSystem.Core.Injection;
using Castle.MicroKernel.Registration;

namespace JCSystem.Core
{
    public static class IoCContainer
    {
        public static IWindsorContainer Container;
        public static IKernel Kernel => Container.Kernel;

        private static readonly object Lock = new object();

        public static T Get<T>()
        {
            lock (Lock)
            {
                return Kernel.Resolve<T>();
            }
        }

        public static object Get(Type service)
        {
            lock (Lock)
            {
                return Kernel.Resolve(service);
            }
        }


        public static void Inject<T>(T item) where T : class
        {
            lock (Lock)
            {
                Kernel.Register(Component.For<T>().IsDefault().NamedAutomatically(Guid.NewGuid().ToString()).Instance(item));
            }
        }

        public static void CreateWebContainer(string endpointName)
        {
            Container = new WindsorContainer();
            Container
                .Install(new SettingsInstaller(endpointName))
                .Install(new RepositoryInstaller());
        }
    }
}