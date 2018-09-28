using Engie.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EngieDAL
{
    public interface IDataReader
    {
        Task<List<EngieNotaInformatiovaDataDto>> ReadDataNotaInformativaAsync(string _connectionPath);
        Task<List<CtrEngieDataDTO>> ReadDataContractEngie(string _connectionPath);
    }
}
