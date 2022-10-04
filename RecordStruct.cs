using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Performance
/// In terms of performance, structs offer performance benefits. 
/// Using record structs is 20 times faster than a regular struct
/// </summary>
namespace TE_CSharp
{
    /// <summary>
    ///  Microsoft has made an improvement to record classes. 
    ///  With C# 9, to declare a record you replaced the “class” keyword with “record.” 
    ///  To avoid confusion when declaring structs as records, 
    ///  C# 10 allows a new syntax to declare a class as a record by mixing record and class keywords
    /// </summary>
    public record struct Product
    {
        //public string Name { get; set; }
        /// <summary>
        /// Immutability
        ///Init-only properties are allowed on record structs
        ///If you try to reassign a property that has the init keyword set after its initialization you’ll get a compilation error
        /// </summary>
        public string Name { get; init; } //init->immutability->cannot be changed
        /// <summary>
        /// record sructs are mutable by default but by using init we can make them immutable
        /// </summary>
        public int Id { get; init; }

    }
    internal class RecordStruct
    {
        public static void Main()
        {
            //Create an instance for the record struct Product
            var product = new Product
            {
                Name = "Books1",
                Id = 1
            };
            var product1 = new Product
            {
                Name = "Books2",
                Id = 2
            };

            //Printing members of the record struct Product
            Console.WriteLine(product);
            Console.WriteLine(product.ToString());
            Console.WriteLine($"{product}");
            Console.WriteLine(product1);
            Console.WriteLine(product1.ToString());
            Console.WriteLine($"{product1}");

            //Equality comparison - compares the value
            Console.WriteLine(product.Equals(product1)); // Returns true

            Console.WriteLine(product == product1); // Returns true

            //With-expressions
            //with keyword ->product1 (Name="Books2" and assigning Id=3 using with keyword
            //Name = "Books2",
            //Id = 2
            var newProduct = product1 with { Id = 3 };

            Console.WriteLine(newProduct.ToString());

            var newProduct1 = product1 with { Name = "Book3" };

            Console.WriteLine(newProduct1.ToString());

            //product.Id = 100; // Error CS8852  Init-only property or indexer 'Product.Name' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.

            Console.WriteLine(product);
        }

    }
}
