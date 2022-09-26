using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// out keyword - return more than value to the calling method
    /// return keyword - one value
    /// </summary>
    internal class OutKeyword
    {
        public static void Main()
        {
            int i;
            int j;
            add(out i, out j);
            Console.WriteLine(i + " " + j); //20 40
        }
        public static void add(out int a,out int b)
        {
            a = 10;
            b = 20;
            a += a;//20
            b += b;//40
        }
    }
}
