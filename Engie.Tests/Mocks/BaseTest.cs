using EngieDAL;
using EngiePOC;
using EngiePOC.DTO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System.IO;
using System.Net.Http;

namespace Engie.Tests
{
    public abstract class BaseTest
    {
        protected TestServer _server;
        protected HttpClient _client;

        protected IConfigurationSection configurationSection;
        public BaseTest()
        {
            var path = Path.GetFullPath(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName) + "\\EngiePOC";

            var configuration = new ConfigurationBuilder()
             .SetBasePath(path)
             .AddJsonFile(path + "\\appsettings.json", false, reloadOnChange: true)
             .Build();

            configurationSection = configuration.GetSection("AppConfiguration");

            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>().ConfigureTestServices(services =>
            {

                //services.AddSingleton(_mockReadData.Object);
                //services.AddSingleton(_mockReaderFactory.Object);
                services.AddTransient<IDataReader, ExcelDataReader>();
                services.AddTransient<IReaderFactory, ReaderFactory>();
                services.AddTransient<IReadDataService, ReadDataService>();
                services.AddTransient<ISignAnywhere, SignAnywhere>();
                services.Configure<AppSettings>(configurationSection);
            }));

            _client = _server.CreateClient();

        }
    }
}
