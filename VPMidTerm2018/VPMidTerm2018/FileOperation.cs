using System;
using System.IO;

namespace VPMidTerm2018
{
    class FileOperation
    {
        private static FileOperation fileops;

        public static FileOperation FILEOPS
        {
            get
            {
                if(fileops == null)
                {
                    fileops = new FileOperation();
                }
                return fileops;
            }
        }

        private FileOperation()
        {
        }

        public string ReadFromFile(string FilePath)
        {
            try
            {
                string data = null;
                using (StreamReader sr = File.OpenText(FilePath))
                {
                    string datarow = null;
                    while ((datarow = sr.ReadLine()) != null)
                    {
                        data += datarow;
                    }
                }
                return data;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public bool WriteToFile(string FilePath, string Data)
        {
            try
            {
                using (StreamWriter sw = File.CreateText(FilePath))
                {
                    sw.Write(Data);
                }
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
