using EngiePOC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using System.IO;

namespace Engie.TestXUnit
{
    public class TestHelper
    {
        public static IConfigurationRoot GetIConfigurationRoot(string outputPath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(outputPath)
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        }

        public static AppConfiguration GetApplicationConfiguration(string outputPath)
        {
            var configuration = new AppConfiguration();

            var iConfig = GetIConfigurationRoot(outputPath);

            iConfig.GetSection("AppConfiguration").Bind(configuration);

            return configuration;
        }
    }


    [TestFixture]
    public class SomeServiceTests
    {
       

        //[SetUp]
        //public void PerTestPrepare()
        //{
        //    //_service = new SomeService(_config);
        //}
    }


}
