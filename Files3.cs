using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// sealed keyword->used to avoid other classes to inherit the class that is sealed
    /// </summary>
    public sealed class Using_Demo
    {
        public int sum=0;
        /// <summary>
        /// Write contents into the file using StremWriter class
        /// CreateText -> method -> creates the file
        /// </summary>
        public void write()
        {
            //Resource management - > Dispose()
            using(StreamWriter sw=File.CreateText(@"E:\TE3.txt"))
            {
                for(int i=0;i<5;i++)
                {
                    sw.WriteLine($"Loop: {i+1} : {sum+=i}");
                }
            }
        }
        /// <summary>
        /// read the contents from the file using StreamReader
        /// </summary>
        public void read()
        {
            using(StreamReader sr=File.OpenText(@"E:\TE3.txt"))
            {
                string contents = null;
                while((contents= sr.ReadLine()) != null)
                {
                    Console.WriteLine(contents);
                }

            }
        }
    }
    internal class Files3
    {
        public static void Main()
        {
            Using_Demo demo = new Using_Demo(); 
            demo.write();
            demo.read();

        }
    }
}
