using Engie.DTO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Engie.Tests
{
    [TestClass]
    public class NotaInformativaReadController_Post_tests : BaseTest
    {
        public SearchEngieDataDto searchEngieData;
        public EngieNotaInformatiovaDataDto engieData;


        [TestInitialize]
        public void TestInitializate()
        {
            //var pathFile = Path.GetFullPath(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName) + "\\EngiePOC\\Files\\fisier_date_test_engie_servicii.xlsx";
            //configurationSection["ExcelFilePath"] = pathFile;

            searchEngieData = new SearchEngieDataDto
            {
                cod_loc_consum = "DGSBSC100537143",
                nr_inreg_dgsr = "300020062",
                nume_client_final = "Ion Ionescu 12",
                telefon = "0724730799"
            };

            engieData = new EngieNotaInformatiovaDataDto
            {
                cod_loc_consum = "DGSBSC100537143",
                nr_inreg_dgsr = "300020062",
                nume_client_final = "Ion Ionescu 12",
                telefon = "0724730799",
                nr_fisa_evidenta = "13",
                aparat_debit_1 = "App debit 1",
                aparat_debit_2 = "App debit 2",
                aparat_debit_3 = "App debit 3",
                aparat_debit_4 = "App debit 4",
                aparat_nr_1 = "App nr 1",
                aparat_nr_2 = "App nr 2",
                aparat_nr_3 = "App nr 3",
                aparat_nr_4 = "App nr 4",
                aparat_tip_1 = "App tip 1",
                aparat_tip_2 = "App tip 2",
                aparat_tip_3 = "App tip 3",
                aparat_tip_4 = "App tip 4",
                bloc_scara_apartament = "33-B-18",
                instalatorul_autorizat_nume_prenume = "Nenea Instalatorulul",
                localitate_judet = "La tara",
                numar = "18",
                reprezentantul_legal_nume_prenume = "No name",
                strada = "saidac Gheorghe"
            };
        }
        [TestMethod]
        public async Task SearchData_Sould_Be_DGSBSC100537143()
        {
            var content = new StringContent(JsonConvert.SerializeObject(searchEngieData), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/Read/SearchData", content);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            var listofResults = JsonConvert.DeserializeObject<List<EngieNotaInformatiovaDataDto>>(result);

            listofResults.First().As<EngieNotaInformatiovaDataDto>().cod_loc_consum.Should().Be("DGSBSC100537143");
        }

        [TestMethod]
        public async Task SearchData_Should_Not_Be_NULL_Or_Empty()
        {
            var content = new StringContent(JsonConvert.SerializeObject(searchEngieData), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/Read/SearchData", content);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            var listofResults = JsonConvert.DeserializeObject<List<EngieNotaInformatiovaDataDto>>(result);

            listofResults.Should().NotBeNullOrEmpty();
        }

        [TestMethod]
        public async Task GetSignLink_Should_Have_Count_2()
        {
            var content = new StringContent(JsonConvert.SerializeObject(engieData), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/Read/GetSignLink", content);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsAsync<List<string>>();
            result.Should().HaveCount(2);
        }

        
    }
}
