using Engie.DTO;
using EngieDAL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engie.Tests.Mocks
{
    public class ReadDataServiceStub
    {

        public IReaderFactory _readerFactory;

        public ReadDataServiceStub(IReaderFactory readerFactory)
        {
            _readerFactory = readerFactory;
        }

        public async Task<List<EngieNotaInformatiovaDataDto>> ReadData(string readerType, string _connectionPath)
        {
            return await _readerFactory.GetReader(readerType).ReadDataNotaInformativaAsync(_connectionPath);
        }
    }
}
