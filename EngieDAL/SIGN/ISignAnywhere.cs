using Engie.DTO;
using System.Collections.Generic;

namespace EngieDAL
{
    public interface ISignAnywhere
    {
        List<string> SendToSign_NVR(EngieNotaInformatiovaDataDto d);
        List<string> SendToSign_CTR(CtrEngieDataDTO d);
    }
}
