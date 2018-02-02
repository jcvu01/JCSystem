using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using JCSystem.Shared.Configuration;

namespace JCSystem.Core.Injection
{
    internal sealed class SettingsInstaller : IWindsorInstaller
    {
        private readonly string _endpointName;

        public SettingsInstaller(string endpointName)
        {
            _endpointName = endpointName;
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            
            //Settings
            container.Register(Component.For<ConnectionStrings>().Instance(ConfigBuilder.ConnectionStrings).LifestyleSingleton());
        }
	    
	}
}