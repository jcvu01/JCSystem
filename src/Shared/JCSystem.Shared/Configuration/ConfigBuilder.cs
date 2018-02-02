using System;
using Microsoft.Extensions.Configuration;

namespace JCSystem.Shared.Configuration
{
    /// <summary>
    /// This class should only be used by the IoC Container (and some tests) to hydrate the *Settings classes
    /// </summary>
    public class ConfigBuilder
    {
        static ConfigBuilder()
        {
	        var machineName = Environment.MachineName.ToLower();

	        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")?.ToLower();

	        Console.WriteLine($"Using Config: {env}");
	        Console.WriteLine($"Using Machine: {machineName}");

			var builder = new ConfigurationBuilder()
		        //.SetBasePath(Directory.GetCurrentDirectory())
		        .AddJsonFile("config.default.json")
		        .AddJsonFile($"config.{env}.json", true)
				.Build();

	        builder.GetSection("ConnectionStrings").Get<ConnectionStrings>();
			//builder.GetSection("WindowsServiceSettings").Bind(WindowsServiceSettings);
		}

	    //public static CheckImageSettings CheckImageSettings { get; set; } = new CheckImageSettings();
	    public static ConnectionStrings ConnectionStrings { get; set; } = new ConnectionStrings();
    }
}
