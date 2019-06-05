using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    static class FindAndReplaceManager
    {
        
        public static void FindNext(string path, string partOfText)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream, Encoding.Default);
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                if(line.StartsWith(partOfText))
                {
                    Console.WriteLine(line);
                    break;
                }
            }
            streamReader.Close();
            fileStream.Close();
        }
    }
}
