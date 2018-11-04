using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AL6
{
    class Program
    {
        static void Main(string[] args)
        {
            // AL6-P1/7
            Console.WriteLine("AL6-P1/7");
            string dirName = @"c:\Program Files";
            DirectoryInfo dirInfo = new DirectoryInfo(dirName);
            if (dirInfo.Exists)
            {
                Console.WriteLine(dirInfo.FullName.ToString() + ": " + dirInfo.CreationTime.ToString());
            }
            else dirInfo.Create();
            // AL6-P2/7
            Console.WriteLine("AL6-P2/7");
            string[] files = Directory.GetFiles(dirName);
            foreach (string s in files)
            {                
                FileInfo fileInf = new FileInfo(s);
                Console.WriteLine(fileInf.FullName.ToString()+" : "+fileInf.CreationTime.ToString()+" : "+fileInf.Length+ "(bites)");
            }
            // AL6-P3/7
            Console.WriteLine("AL6-P3/7");
            Directory.CreateDirectory(@"c:\Program Files Copy");
            // AL6-P4/7
            Console.WriteLine("AL6-P4/7");
            var files2 = dirInfo.GetFiles()[0];
            string newPath = @"c:\Program Files Copy\"+files2.Name;
            string path = files2.FullName.ToString(); ;

            FileInfo fileCopy = new FileInfo(path);

            if (fileCopy.Exists)
            {
                File.Copy(path, newPath, true);                           
            }


        }
    }
}
