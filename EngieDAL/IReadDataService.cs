using Engie.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EngieDAL
{
    public interface IReadDataService
    {
        Task<List<EngieNotaInformatiovaDataDto>> ReadDataNotaInformativa(string readerType, string _connectionPath);
        Task<List<CtrEngieDataDTO>> ReadDataContractEngie(string readerType, string _connectionPath);
    }
}
