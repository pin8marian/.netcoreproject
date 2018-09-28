using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace Engie.Tests
{
    [TestClass]
    public class Util_Tests
    {
        [TestMethod]
        public async Task Split_Weburl_Return_WorkstepId()
        {
            var stringUrl = "http://launch.xyzmo.com/SignificantAndroidAppLauncher.aspx?WorkstepId=37E01D9D5AD1A4A93CCB1EE9D7C40C4C8DC6668B39DD886F574722E9DC3D19632D44ECDE94D3EB88BA1BD7AF7E53F62A&server=beta3.testlab.xyzmo.com&port=57003&protocol=http";
            var splittedString = stringUrl.Split("=")[1].Split("&").First();
            splittedString.Should().BeEquivalentTo("37E01D9D5AD1A4A93CCB1EE9D7C40C4C8DC6668B39DD886F574722E9DC3D19632D44ECDE94D3EB88BA1BD7AF7E53F62A");
        }
    }
}
