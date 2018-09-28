using Engie.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EngieDAL
{
    public class DbDataReader : IDataReader
    {
        public Task<List<CtrEngieDataDTO>> ReadDataContractEngie(string _connectionPath)
        {
            throw new NotImplementedException();
        }

        public Task<List<EngieNotaInformatiovaDataDto>> ReadDataNotaInformativa(string _connectionPath)
        {
            throw new NotImplementedException();
        }

        public Task<List<EngieNotaInformatiovaDataDto>> ReadDataNotaInformativaAsync(string _connectionPath)
        {
            throw new NotImplementedException();
        }
    }
}
