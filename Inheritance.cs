using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Inheritance - reusability
/// 4 types - Single,Multi-level,Hybrid,Hierarchial
/// Multiple - not supported - Interfaces are used
/// </summary>
namespace TE_CSharp
{
    /// <summary>
    /// Parent class with protected variables
    /// </summary>
    public class Emp
    {
        protected int eid;
        protected string ename;
        protected void EmpDetails()
        {
            Console.WriteLine("Emp Class");
        }
    }
    /// <summary>
    /// Child class - can access the protected variables
    /// </summary>
    public class ITDept:Emp
    {
        protected int did;
        protected string dname;  
        public void DeptDetails()
        {
            EmpDetails();
        }
    }
    public class Admin:ITDept
    {
        /// <summary>
        /// Assign the values for the eid and ename from Emp class
        /// Assign the values for the did and dname from ITDept class
        /// </summary>
        public void GetDetails()
        {
            eid = 100;
            ename = "John";
            did = 101;
            dname = "IT";
            Console.WriteLine($"{eid}:{ename}:{did}:{dname}");
            EmpDetails();
        }

    }
    internal class Inheritance
    {
        public static void Main()
        { 
            //Instance for the child class
            //ITDept dept = new ITDept();
            //dept.GetDetails();

            Admin admin = new Admin();
            admin.GetDetails();
            admin.DeptDetails();

        }
    }
}
