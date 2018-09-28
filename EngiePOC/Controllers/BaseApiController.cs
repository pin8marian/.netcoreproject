using EngiePOC.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EngiePOC.Controllers
{
    public class BaseApiController : ControllerBase
    {
        protected AppSettings _appConfiguration;

        public BaseApiController(IOptions<AppSettings> appConfiguration)
        {
            _appConfiguration = appConfiguration.Value;
            //_appConfiguration.ExcelFilePath = Path.GetFullPath(Directory.GetCurrentDirectory() + "\\Files\\" + _appConfiguration.ExcelFileName);
        }
    }
}