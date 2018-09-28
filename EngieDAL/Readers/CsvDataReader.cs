using Engie.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EngieDAL
{
    public class CsvDataReader : IDataReader
    {
        public Task<List<EngieNotaInformatiovaDataDto>> ReadDataNotaInformativaAsync(string _connectionPath)
        {
            throw new NotImplementedException();
        }

        Task<List<CtrEngieDataDTO>> IDataReader.ReadDataContractEngie(string _connectionPath)
        {
            throw new NotImplementedException();
        }
    }
}
