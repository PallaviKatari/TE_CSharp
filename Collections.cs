using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TE_CSharp
{
    /// <summary>
    /// Collections -> type of class -> dynamic memory allocation -> store and retrieve data
    /// using System.Collections;
    /// using System.Collections.Generic;
    /// using System.Collections.Concurrent;
    /// </summary>
    internal class Collections
    {
        /// <summary>
        /// ArrayList -> class -> using System.Collections;
        /// It is not type specific
        /// </summary>
        public static void ArrayList_Demo()
        {
            ArrayList arrayList=new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2.23);
            arrayList.Add("John");
            arrayList.Add('a');
            foreach(object obj in arrayList)
            {
                Console.WriteLine(obj);
            }

        }
        public static void Main()
        {
            ArrayList_Demo();
            Console.WriteLine("-----------------------------------------");

        }

    }
}
