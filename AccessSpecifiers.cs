using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// Access Specifiers - Visibility
    /// 5 types - public,private,protected(inheritance),internal,internal protected
    /// </summary>
    public class AccessSpecifiers
    {
        public int eid;
        public string ename;
        //can access only within the class
        private int age;
        public void EmpDetails(int id, string name)
        {
            eid = id;
            ename = name;
            Console.WriteLine($"{ename}:{eid}");
        }
    }
    public class AccessSpecifiersMain
    {
        public static void Main()
        {
            AccessSpecifiers accessSpecifiers = new AccessSpecifiers();
            accessSpecifiers.EmpDetails(1, "John");
            //accessSpecifiers.age = 25;//inaccessible outside the class
            //Console.WriteLine(accessSpecifiers.age);//inaccessible outside the class

        }
    }
    
}
