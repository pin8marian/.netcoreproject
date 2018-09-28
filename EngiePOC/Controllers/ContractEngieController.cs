using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Engie.DTO;
using EngieDAL;
using EngiePOC.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace EngiePOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractEngieController : BaseApiController
    {
        private string _contractEngieExcelFilePath;
        private string _fileType;

        public IReadDataService _readDataService;
        public ISignAnywhere _signAnywhere;
        readonly ILogger<ReadController> logger;

        public ContractEngieController(ILogger<ReadController> log, IReadDataService readDataService, ISignAnywhere signAnywhere, IOptions<AppSettings> appConfiguration) : base(appConfiguration)
        {
            _readDataService = readDataService;
            _contractEngieExcelFilePath = appConfiguration.Value.ContractElExcelFilePath;
            _fileType = appConfiguration.Value.ExcelDocument;
            _signAnywhere = signAnywhere;
            logger = log;
        }

        // GET: api/Read
        [HttpGet]
        public async Task<IEnumerable<CtrEngieDataDTO>> Get()
        {
            var resReturened = await _readDataService.ReadDataContractEngie(_fileType, _contractEngieExcelFilePath);
            return resReturened;
        }

        [HttpPost]
        [Route("SearchData")]
        //[HttpPost(Name = "SearchData")]
        public async Task<IEnumerable<CtrEngieDataDTO>> SearchData([FromBody]SearchCtrEngieDataDto dataDto)
        {
            var resReturened = await _readDataService.ReadDataContractEngie(_fileType, _contractEngieExcelFilePath);

            var query = resReturened.Select(x => x);
            if (!string.IsNullOrEmpty(dataDto.cnp))
                query = query.Where(x => x.cnp.ToLower().Contains(dataDto.cnp.ToLower()));
            if (!string.IsNullOrEmpty(dataDto.nr_contract))
                query = query.Where(x => x.nr_contract.ToLower().Contains(dataDto.nr_contract.ToLower()));
            if (!string.IsNullOrEmpty(dataDto.nume_contractant))
                query = query.Where(x => x.nume_contractant.ToLower().Contains(dataDto.nume_contractant.ToLower()));
            if (!string.IsNullOrEmpty(dataDto.telefon))
                query = query.Where(x => x.tel.ToLower().Contains(dataDto.telefon.ToLower()));

            return query.ToList();
        }

        // POST: api/Read
        [HttpPost]
        [Route("GetSignLink")]
        public List<string> GetSignLink([FromBody]CtrEngieDataDTO engieData)
        {
            return _signAnywhere.SendToSign_CTR(engieData);
        }

        // PUT: api/Read/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}