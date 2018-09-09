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

        public void GetFullPath(string mfid, string cls, DateTime navdate){
            
        }

        public void GetFullPath (int calcid){

        }

        public string CreateFilenameEa(string mfid, string cls, DateTime navdate, bool isZwa = false, string investor = null){
            var filename =  $"{mfid}_{cls}_{navdate.ToString("yyyyMMdd")}";
            
            if (investor != null) {
                filename = $"{filename}_{investor}";
            }

            //@todo Feststellung Spezialfonds

            return Path.Combine(isZwa?"Zwa": String.Empty, filename);

        }
    }
}
