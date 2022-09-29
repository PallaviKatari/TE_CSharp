using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Collection of classes 
/// Namespace1
/// </summary>
namespace Namespace1
{
    internal class Class1
    {
        public static void Method1()
        {
            Console.WriteLine("Message 1");
        }
    }
}
/// <summary>
/// Namespace2
/// </summary>
namespace Namespace2
{
    internal class Class1
    {
        public static void Method1()
        {
            Console.WriteLine("Message 2");
        }
    }
}
/// <summary>
/// Namespace3 with 2 Nested Namespaces
/// </summary>

namespace Namespace3
{
    namespace NestedNamespace1
    {
        internal class Class1
        {
            public static void Method1()
            {
                Console.WriteLine("Message NestedNamespace1");
            }
        }
    }
    namespace NestedNamespace2
    {
        internal class Class1
        {
            public static void Method1()
            {
                Console.WriteLine("Message NestedNamespace2");
            }
        }
    }
}
/// <summary>
/// Invoking the Method1() from various namespaces
/// </summary>

namespace MainNamespace
{
    internal class Class1
    {
        public static void Main()
        {
            Namespace1.Class1.Method1();
            Namespace2.Class1.Method1();
            Namespace3.NestedNamespace1.Class1.Method1();
            Namespace3.NestedNamespace2.Class1.Method1();
        }
    }
}
