using System;
using Ert.Core.Services;
using Xunit;

namespace Ert.Core.Test
{
    public class FileServiceTest
    {

        private FileService _service = new FileService() { DataDir = "/dir1/dir2" };

        [Theory]
        [InlineData("DU1008", "SAN", "20081018", false, null, "DU1008_SAN_20081018")]
        [InlineData("DU1008", "SAN", "20081018", true, null, "Zwa/DU1008_SAN_20081018")]
        [InlineData("DU1008", "SAN", "20081018", false, "12345", "DU1008_SAN_20081018_12345")]
        public void Test1(string mfid, string cls, string nav, bool iszwa, string investor,string erg){

            var filename = _service.CreateFullFilenameEa(mfid, cls, DateTime.ParseExact(nav, "yyyyMMdd",null), iszwa,investor);

            Assert.True(filename == erg,$"Wrong filename: {filename}" );
        } 
    }
}
