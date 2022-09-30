using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// File and FileInfo Methods and Properties
    /// </summary>
    internal class Files5
    {
        public static void Main()
        {
            string path = @"E:\TE.txt";

            //Exists
            if(File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }
            Console.WriteLine("-----------------------------------------");

            //ReadAllLines
            string[] content;
            content = File.ReadAllLines(path);
            Console.WriteLine(content[0]);
            Console.WriteLine(content[1]);
            Console.WriteLine("-----------------------------------------");

            //ReadAllText
            string content1;
            content1 = File.ReadAllText(path);
            Console.WriteLine(content1);
            Console.WriteLine("-----------------------------------------");

            //LINQ
            var str=from info in File.ReadLines(path) //@"E:\TE.txt"
                    where info.StartsWith("Files") || info.Contains("append")
                    select info;

            File.AppendAllLines(@"E:\TE1.txt", str);

            //Move the file from one path to another
            //File.Move(@"E:\TE2.txt", @"E:\PALLAVI\TE2.txt");
            //File.Move(Source,destination)
            //File.Move(@"E:\PALLAVI\TE3.txt", @"E:\TE3.txt");

            //Copy
            //string path = @"E:\TE.txt";
            string dest_path= @"E:\TE4.txt";

            File.Copy(path, dest_path);





        }
    }
}
