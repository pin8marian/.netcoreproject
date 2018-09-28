using Engie.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engie.Tests
{
    [TestClass]
    public class ContractEngieReadController_Get_Tests : BaseTest
    {
      
        [TestMethod]
        public async Task HttpGet_ContractEngie_from_excel_Is_not_null()
        {
            var response = await _client.GetAsync("/api/ContractEngie");
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            var listofResults = JsonConvert.DeserializeObject<List<EngieNotaInformatiovaDataDto>>(result);

            Assert.IsNotNull(listofResults);
        }

        [TestMethod]
        public async Task ReadData_from_excel_Is_eqaul_with_39()
        {
            var response = await _client.GetAsync("/api/ContractEngie");
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            var listofResults = JsonConvert.DeserializeObject<List<EngieNotaInformatiovaDataDto>>(result);

            Assert.AreEqual(39, listofResults.Count);
        }
    }
}
