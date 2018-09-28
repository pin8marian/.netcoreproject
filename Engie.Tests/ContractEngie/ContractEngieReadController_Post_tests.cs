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
    public class ContractEngieReadController_Post_tests : BaseTest
    {
        public SearchCtrEngieDataDto searchCtrEngieData;
        public CtrEngieDataDTO engieData;


        [TestInitialize]
        public void TestInitializate()
        {
            //var pathFile = Path.GetFullPath(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName) + "\\EngiePOC\\Files\\fisier_date_test_engie_servicii.xlsx";
            //configurationSection["ExcelFilePath"] = pathFile;

            searchCtrEngieData = new SearchCtrEngieDataDto
            {
                nr_contract = "4000000125",
                cnp = "1790121445364",
                nume_contractant = "Eugen Cioclea",
                telefon = "740222124"
            };

            engieData = new CtrEngieDataDTO
            {
                nr_contract = "4000000123",
                data_semnarii = "04-07-2018",
                nume_contractant = "Bratcoveanu Nicoleta",
                localitate = "Bucuresti",
                strada = "Aleea Alexandru",
                nr = "1",
                cod_cladire = "bl1",
                apt = "1",
                cod_postal = "10203",
                judet = "Sector 1",
                tel = "740222122",
                email = "client@codestudio.ro",
                serie_nr_ci = "RX442362",
                eliberat_de = "SPCEPS1",
                eliberat_la_data = "01-01-2000",
                valabil_pana_la = "31-12-2030",
                cnp = "1790121445362",
                iban = "RO00BTRL00042163",
                banca = "BT",
                c_localitatea = "Bucuresti",
                c_strada = "Aleea Alexandru",
                c_nr = "1",
                c_cod_cladire = "bl1",
                c_apt = "1",
                c_cod_postal = "10203",
                c_judet = "Sector 1",
                c_nr_loc_consum = "XX123000456",
                c_cod_loc_consum = "ZZ098755555",
                c_distribuitor = "Enel",
                c_serie_contor = "BB4456",
                c_putere = "220",
                denumire_oferta = "engie e-Ampero",
                pret_dela = "01-07-2018",
                pret_pana_la = "01-07-2020",
                pret = "184",
                nivel_tensiune = "35",
                termen_plata = "integral",
                f_localitate = "Bucuresti",
                f_strada = "Aleea Alexandru",
                f_nr = "1",
                f_ap = "bl1",
                f_cod_postal = "10203",
                f_judet = "Sector 1",
                ianuarie = "",
                februarie = "",
                martie = "",
                aprilie = "",
                mai = "",
                iunie = "",
                iulie = "",
                august = "",
                septembrie = "",
                octombrie = "",
                noiembrie = "",
                decembrie = "",
                total = "",
                cod_move_in = "4000000123",
                cod_partener = "300004449998",
                vanzator = "Brian Tracy",
                client = "Bratcoveanu Nicoleta"
            };
        }
        [TestMethod]
        public async Task SearchData__Nr_Contract_Sould_Be_4000000125()
        {
            var content = new StringContent(JsonConvert.SerializeObject(searchCtrEngieData), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/ContractEngie/SearchData", content);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            var listofResults = JsonConvert.DeserializeObject<List<CtrEngieDataDTO>>(result);

            listofResults.First().As<CtrEngieDataDTO>().nr_contract.Should().Be("4000000125");
        }

        [TestMethod]
        public async Task SearchData_Should_Not_Be_NULL_Or_Empty()
        {
            var content = new StringContent(JsonConvert.SerializeObject(searchCtrEngieData), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/ContractEngie/SearchData", content);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            var listofResults = JsonConvert.DeserializeObject<List<CtrEngieDataDTO>>(result);

            listofResults.Should().NotBeNullOrEmpty();
        }

        [TestMethod]
        public async Task GetSignLink_Should_Have_Count_2()
        {
            var content = new StringContent(JsonConvert.SerializeObject(engieData), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/ContractEngie/GetSignLink", content);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsAsync<List<string>>();
            result.Should().HaveCount(2);
        }


    }
}
