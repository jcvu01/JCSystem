using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using JCSystem.Core.Repositories.Interface;

namespace JCSystem.Core.Injection
{
    internal sealed class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            			
            //All repositories interface
            container.Register(Classes.FromAssemblyContaining<ISongsManager>()
                .InNamespace("JCSystem.Core.Repositories.Interface", true)
                .WithServiceAllInterfaces()
                .LifestyleSingleton());

		}
	}
}
