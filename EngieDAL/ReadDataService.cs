using Engie.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EngieDAL
{
    public class ReadDataService: IReadDataService
    {
        public IReaderFactory _readerFactory;

        public ReadDataService(IReaderFactory readerFactory)
        {
            _readerFactory = readerFactory;
        }

        public Task<List<EngieNotaInformatiovaDataDto>> ReadDataNotaInformativa(string readerType, string _connectionPath) {

            return _readerFactory.GetReader(readerType).ReadDataNotaInformativaAsync(_connectionPath);
        }

        public Task<List<CtrEngieDataDTO>> ReadDataContractEngie(string readerType, string _connectionPath)
        {
            return _readerFactory.GetReader(readerType).ReadDataContractEngie(_connectionPath);
        }
    }
}
