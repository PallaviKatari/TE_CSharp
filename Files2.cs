using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// FILE class -> properties and methods
    /// </summary>
    public class Files_Demo2
    {
        /// <summary>
        /// File class demo
        /// </summary>
        public void File_demo()
        {
            File.WriteAllText(@"E:\TE2.txt", "I am WriteAllText method from File class");
            string path = @"E:\TE2.txt";
            FileInfo fi = new FileInfo(path);
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastWriteTime);
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.Exists);
        }
        /// <summary>
        /// Retrieve all the Files and Directories from E:\
        /// </summary>
        public void Directory_demo()
        {
            foreach(string file in Directory.GetFiles(@"E:\"))
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("-----------------------------------------");
            foreach (string file1 in Directory.GetDirectories(@"E:\"))
            {
                Console.WriteLine(file1);
            }
        }

    }
    internal class Files2
    {
        public static void Main()
        {
            Files_Demo2 files_Demo2 = new Files_Demo2();
            files_Demo2.File_demo();
            Console.WriteLine("-----------------------------------------");
            files_Demo2.Directory_demo();
        }
    }
}
