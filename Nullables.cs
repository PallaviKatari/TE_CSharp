using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// Nullables - C# 2.0
    /// Value types - int,char,float,double,boolean
    /// Assign null values to the value types
    /// </summary>
    internal class Nullables
    {
        public static void Main()
        {
            int a = 10;
            Console.WriteLine(a);
            //Assigning null value using shorthand operator ?
            int? b = null;
            Console.WriteLine(b);
            //Assigning null value using Nullable Generic class
            Nullable<int> c = null;
            Console.WriteLine("Hello "+c+"  Trainees");
            //Null Coalescing Operator ??
            int? score = null;
            int? defaultscore = 65;
            int? grade;
            grade = score ?? defaultscore;
            Console.WriteLine(grade);

        }
    }
}
