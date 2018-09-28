using Engie.DTO;
using EngieDAL;
using EngiePOC;
using EngiePOC.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Engie.TestXUnit
{
    public class ReadController_Get_Test
    {
        private AppConfiguration configuration;
        private TestServer _server;
        private HttpClient _client;

        private IOptions<AppConfiguration> _config;

        //[OneTimeSetUp]
        //public void GlobalPrepare()
        //{
        //    var configuration = new ConfigurationBuilder()
        //       .SetBasePath(Directory.GetCurrentDirectory())
        //       .AddJsonFile("appsettings.json", false)
        //       .Build();

        //    _config = Options.Create(configuration.GetSection("AppConfiguration").Get<AppConfiguration>());
        //}
        
        //[Fact]
        //public void Init() {
        //    configuration = TestHelper.GetApplicationConfiguration(Directory.GetCurrentDirectory());

        //    _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        //    _client = _server.CreateClient();
        //    var services = new ServiceCollection();
        //    services.AddSingleton(configuration);
        //}


        [Fact]
        public async Task TestF_For_test()
        {
            var configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", false)
               .Build();
            var webHost = new WebHostBuilder().ConfigureTestServices(s => s.AddSingleton<IReadDataService, ReadDataService>().Configure<AppConfiguration>(configuration.GetSection("AppConfiguration")))
                .UseStartup<Startup>();
            //_client = _server.CreateClient();
            var testserver = new TestServer(webHost);
            var _client = testserver.CreateClient();
          

            var response = await _client.GetAsync("/api/read");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            
            var listofResults = JsonConvert.DeserializeObject<List<EngieDataDto>>(responseString);
            //listofResults.Should()
            //Assert.AreEqual(3, listofResults.Count);
            var serviceMock = new Mock<IReadDataService>();
            //serviceMock.Setup(x => x.ReadData(configuration.ExcelDocument, configuration.ExcelFilePath)).Returns(() => new System.Collections.Generic.List<DTO.EngieDataDto> {
            //    new DTO.EngieDataDto{ id=1, FirstName="test1", LastName="test2"},
            //    new DTO.EngieDataDto{id=2, FirstName="test2", LastName="test2.1" },
            //    new DTO.EngieDataDto{ id=3, FirstName="test3", LastName="test2.2"},

            //});
            
            //var controller = new ReadController(serviceMock.Object, _config);
            
           
        }
    }
}
