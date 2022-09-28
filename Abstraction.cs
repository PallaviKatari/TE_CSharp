using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Abstraction - information hiding - abstract classes or interfaces
/// Abstract classes - abstract keyword, abstract and non-abstract methods,variables
/// Abstract classes - cannot create an instance , they must be inherited , all the abstract methods must be overriden
/// </summary>
namespace TE_CSharp
{
    /// <summary>
    /// ABSTRACT CLASS
    /// </summary>
    public abstract class Bonus
    {
        //protected variable
        protected int bonus;
        //abstract mehod - no implementation - method declaration
        public abstract void GetBonus();
        //non-abstract method
        public void CalcBonus(int salary)
        {
            bonus = bonus * salary; //5*20000
            Console.WriteLine($"Bonus is:{bonus}");//100000
        }
    }
    /// <summary>
    /// Child class - inheriting the abstract class Bonus
    /// </summary>
    public class IT:Bonus
    {
        /// <summary>
        /// Method Definition - Implementation of the abstract method - Method Overriding
        /// </summary>
        public override void GetBonus()
        {
            bonus = 5;
        }

    }
    /// <summary>
    /// Child class - inheriting the abstract class Bonus
    /// </summary>
    public class Testing : Bonus
    {
        /// <summary>
        /// Method Definition - Implementation of the abstract method - Method Overriding
        /// </summary>
        public override void GetBonus()
        {
            bonus = 3;
        }

    }
    internal class Abstraction
    {
        public static void Main()
        {
            //Base - > Derived
            Bonus bonus;
            bonus = new IT();
            bonus.GetBonus();
            bonus.CalcBonus(20000);
            bonus=new Testing();
            bonus.GetBonus();
            bonus.CalcBonus(20000);
            

        }
    }
}
