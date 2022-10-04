using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// GENERICS -> TYPE SPECIFIC DATA
/// Generics -> class,property,method,variable
/// </summary>
namespace TE_CSharp
{
    /// <summary>
    /// GENERIC CLASS
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class Generics<T>//int
    {
        //Generic Variable
        public T genericvariable;
        /// <summary>
        /// Generic constructor with one parameter
        /// </summary>
        /// <param name="val"></param>
        public Generics(T val)
        {
            genericvariable = val;
        }
        /// <summary>
        /// Generic method
        /// </summary>
        /// <param name="genericparameter"></param>
        public void GenericMethod(T genericparameter)
        {
            Console.WriteLine($"EmpID:{genericvariable}");
            Console.WriteLine($"Salary: {genericparameter}");
            Console.WriteLine($"{typeof(T).ToString()}");
        }
        /// <summary>
        /// Generic property
        /// </summary>
        public T GenericProperty { get; set; }

    }
}

namespace Generics_Evolution
{
    public class Generics
    {
        public static void Stage1()
        {
            bool result = AreEqual("ABC",10);//Value type
            if(result)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

        }
        //OBJECT -> REFERENCE DATATYPE -> not type specific(parameter 1 can be int, parameter 2 can be string)
        //OBJECT -> REFERENCE DATATYPE
        //Value to reference type - BOXING
        //reference to value type - UNBOXING
        //BOXING/UNBOXIN TECHNIQUE  -> POOR PERFORMANCE
        public static bool AreEqual(object value1,object value2)
        {
            return value1 == value2;
        }

        public static void Main()
        {
            //Invoking the static methods within the Generics_Evolution namespace
            Stage1();
            Stage2();
            Stage3_Generics();
            Console.WriteLine("----------------------------------------");
            //Create an instance the TE_CSharp.Generic class
            TE_CSharp.Generics<int> generics = new TE_CSharp.Generics<int>(100);
            generics.GenericMethod(25000);
            generics.GenericProperty = 24;
            Console.WriteLine($"Age:{generics.GenericProperty}");
            Console.WriteLine("----------------------------------------");
            
            TE_CSharp.Generics<double> generics1 = new TE_CSharp.Generics<double>(100);
            generics1.GenericMethod(25000.50);
            generics1.GenericProperty = 24.5;
            Console.WriteLine($"Age:{generics1.GenericProperty}");
            Console.WriteLine("----------------------------------------");

            TE_CSharp.Generics<string> generics2 = new TE_CSharp.Generics<string>("E100");
            generics2.GenericMethod("John:25000");
            generics2.GenericProperty = "John:24";
            Console.WriteLine($"Age:{generics2.GenericProperty}");
            Console.WriteLine("----------------------------------------");

        }
        //-----------------------------------------------------------------------//
        /// <summary>
        /// Implementation of Overloading by overcoming the BOXING/UNBOXIN TECHNIQUE in the above object concept
        /// </summary>
        static void Stage2()
        {
            bool result = AreEqual_INT(10, 10);//Value type
            bool result1 = AreEqual_STRING("ABC","ABC");//Value type
            if (result1)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

        }
        public static bool AreEqual_INT(int value1,int value2)
        {
            return value1 == value2;
        }
        public static bool AreEqual_STRING(string value1, string value2)
        {
            return value1 == value2;
        }
        public static bool AreEqual_FLOAT(float value1, float value2)
        {
            return value1 == value2;
        }
        public static bool AreEqual_DOUBLE(double value1, double value2)
        {
            return value1 == value2;

        }
        //-----------------------------------------------------------------------//
        /// <summary>
        /// Implementation of Generics by overcoming the redundancy in the above overloading concept
        /// </summary>
        public static void Stage3_Generics()
        {
            bool result = AreEqual1 <int>(10,10);
            bool result1 = AreEqual1<string>("ABC", "ABC");
            bool result2 = AreEqual1<string,int>("ABC", 10);
            if (result1)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

        }
        public static bool AreEqual1<T>(T value1, T value2) //int value1,int value2
        {
            return value1.Equals(value2);

        }
        public static bool AreEqual1<T,T1>(T value1, T1 value2) //string value1,int value2
        {
            return value1.Equals(value2);

        }
    }
}
