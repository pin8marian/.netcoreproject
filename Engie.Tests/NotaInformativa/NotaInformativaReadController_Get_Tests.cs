using Engie.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engie.Tests
{
    [TestClass]
    public class NotaInformativaReadController_Get_Tests : BaseTest
    {
      
        //public IDataReader _mockReadDataService;

        //[TestInitialize]
        //public void TestInitializate()
        //{
        //    _mockReadDataService = new ExcelDataReader();

        //    var pathFile = Path.GetFullPath(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName) + "\\EngiePOC\\Files\\fisier_date_test_engie_servicii.xlsx";

        //    configurationSection["ExcelFilePath"] = pathFile;
            
        //}
        [TestMethod]
        public async Task HttpGet_Read_from_excel_Is_not_null()
        {
            var response = await _client.GetAsync("/api/Read");
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            var listofResults = JsonConvert.DeserializeObject<List<EngieNotaInformatiovaDataDto>>(result);

            Assert.IsNotNull(listofResults);
        }

        [TestMethod]
        public async Task ReadData_from_excel_Is_eqaul_with_39()
        {
            var response = await _client.GetAsync("/api/read");
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            var listofResults = JsonConvert.DeserializeObject<List<EngieNotaInformatiovaDataDto>>(result);

            Assert.AreEqual(39, listofResults.Count);
        }
    }
}
