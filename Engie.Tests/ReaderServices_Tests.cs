using EngieDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Engie.Tests
{
    [TestClass]
    public class ReaderServices_Tests : BaseTest
    {
        public IReadDataService _mockReadDataService;

        public string pathFile;

        public ReaderServices_Tests()
        {

        }
        public ReaderServices_Tests(IReadDataService readDataService)
        {
            _mockReadDataService = readDataService;
        }

        [TestInitialize]
        public void TestInitializate()
        {
            pathFile = Path.GetFullPath(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName) + "\\EngiePOC\\Files\\fisier_date_test_engie_servicii.xlsx";
            configurationSection["ExcelFilePath"] = pathFile;
        }

        [TestMethod]
        public void ExcelDataReader_Read_Is_not_null()
        {
            var response = _mockReadDataService.ReadDataNotaInformativa("xls",pathFile);

            Assert.IsNotNull(response);
        }

    }
}
