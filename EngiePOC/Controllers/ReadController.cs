using System;
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

    //readonly ILogger<ValuesController> logger;
    //public DefaultController(ILogger<ValuesController> log)
    //{
    //    logger = log;
    //}

    [Route("api/[controller]")]
    [ApiController]
    public class ReadController : BaseApiController
    {
        private string _notaVerificareExcelFilePath;
        private string _fileType;

        public IReadDataService _readDataService;
        public ISignAnywhere _signAnywhere;
        readonly ILogger<ReadController> logger;

        public ReadController(ILogger<ReadController> log, IReadDataService readDataService, ISignAnywhere signAnywhere, IOptions<AppSettings> appConfiguration) : base(appConfiguration)
        {
            _readDataService = readDataService;
            _notaVerificareExcelFilePath = appConfiguration.Value.NotaVericareExcelFilePath;
            _fileType = appConfiguration.Value.ExcelDocument;
            _signAnywhere = signAnywhere;
            logger = log;
        }

        // GET: api/Read
        [HttpGet]
        public async Task<IEnumerable<EngieNotaInformatiovaDataDto>> Get()
        {
            //logger.Log(LogLevel.Information, _notaVerificareExcelFilePath);
            var resReturened = await _readDataService.ReadDataNotaInformativa(_fileType, _notaVerificareExcelFilePath);
            return resReturened.Take(100).ToList();
        }

        [HttpPost]
        [Route("SearchData")]
        //[HttpPost(Name = "SearchData")]
        public async Task<IEnumerable<EngieNotaInformatiovaDataDto>> SearchData([FromBody]SearchEngieDataDto dataDto)
        {
            var resReturened = await _readDataService.ReadDataNotaInformativa(_fileType, _notaVerificareExcelFilePath);

            var query = resReturened.Select(x => x);
            if (!String.IsNullOrEmpty(dataDto.cod_loc_consum))
                query = query.Where(x => x.cod_loc_consum.ToLower().Contains(dataDto.cod_loc_consum.ToLower()));
            if (!String.IsNullOrEmpty(dataDto.nr_inreg_dgsr))
                query = query.Where(x => x.nr_inreg_dgsr.ToLower().Contains(dataDto.nr_inreg_dgsr.ToLower()));
            if (!String.IsNullOrEmpty(dataDto.nume_client_final))
                query = query.Where(x => x.nume_client_final.ToLower().Contains(dataDto.nume_client_final.ToLower()));
            if (!String.IsNullOrEmpty(dataDto.telefon))
                query = query.Where(x => x.telefon.ToLower().Contains(dataDto.telefon.ToLower()));

            return query.ToList();
        }

        // POST: api/Read
        [HttpPost]
        [Route("GetSignLink")]
        public List<string> GetSignLink([FromBody]EngieNotaInformatiovaDataDto engieData)
        {
            return _signAnywhere.SendToSign_NVR(engieData);
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
