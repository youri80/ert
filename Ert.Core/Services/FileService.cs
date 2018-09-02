using System;
using System.IO;

namespace Ert.Core.Services
{
    public class FileService
    {
        public string DataDir { get;  set; }



        public void SaveEa(string filename, byte[] content)
        {
            File.WriteAllBytes(Path.Combine(DataDir, filename), content);
        }

        public void GetEa(string mfid, string cls, DateTime navdate){
            
        }

        public string FilePath(){
             throw new NotImplementedException();
        }

        public string CreateFullFilenameEa(string mfid, string cls, DateTime navdate, bool isZwa = false, string investor = null){
            var filename = $"{mfid}_{cls}_{navdate.ToString("yyyyMMdd")}";

            if (investor != null) {
                filename = filename + $"_{investor}";
            }
            return Path.Combine(DataDir, isZwa?"Zwa": String.Empty, filename);

        }
    }
}
