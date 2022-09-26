using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// Structures - Value type datatypes - Collection of variable with different datatypes
    /// Methods and Properties
    /// 
    /// CLASS - large Projects , reuse(inheritance), protected(access specifier(inheritance)
    ///         Constructures(default) and destructures, reference type(heap memory)
    /// STRUCTURES - small projects, no inheritance(no reusability,no protected access specifier),
    ///         Constructures(parameterized),Value types(stack memory)
    /// </summary>
    struct EmployeeDetails
    {
        //Variables
        public int empid;
        public string empname;
        /// <summary>
        /// parametrized constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public EmployeeDetails(int id,string name)
        {
            empid = id;
            empname = name;
        }
        /// <summary>
        /// Display the employee details through an instance method
        /// </summary>
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee no {empid} is {empname}");
        }

    }
    internal class Structures
    {
        /// <summary>
        /// Access the employee details from the structure
        /// </summary>
        public static void Main()
        {
            EmployeeDetails empDetails = new EmployeeDetails(100,"John");
            empDetails.DisplayDetails();
        }
    }
}
