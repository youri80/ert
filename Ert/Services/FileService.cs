﻿using System;
using System.IO;

namespace Ert.Services
{
    public class FileService
    {
        public string DataDir { get; private set; }

        public void SaveEa(string filename, byte[] content)
        {
            File.WriteAllBytes(Path.Combine(DataDir, filename), content);
        }

        public void GetEa(string mfid, string cls, DateTime navdate){

        }

        public string FilePath(){
             throw new NotImplementedException();
        }
    }
}