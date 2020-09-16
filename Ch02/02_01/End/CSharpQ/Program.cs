using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpQ
{
    /// 1.	What’s REFERENCE TYPES? 
    ///     
    ///     Reference types are objects that store references 
    ///     to the actual data. 
    ///     
    ///     Class, Interface, delegate, object & string --> Reference types


    /// Class
    class Program
    {
        // Object
        static object Book { get; set; } = "Srinivas Nalla Book";

        // Delegate - function pointers
        //when you invoke delegat it return function with computed value
        //Link for more details : https://www.pluralsight.com/guides/how-why-to-use-delegates-csharp
        delegate void del(string value);

        static void Main(string[] args)
        {
            del d = x => Console.WriteLine(x);
            d.Invoke(Book.ToString());
            Console.ReadLine();
        }
    }
}

    /// Interface - Reference Type
    interface Student
    {
        // Some content
    }

    /// ==================================================================================
    /// 2.	What are VALUE TYPES? 
    /// 
    ///     Value types actually hold values. Assigning one value type 
    ///     to another literally copies that value.

    /// Structs, enums, bools, numberic types 
    public struct Book
    {
        public string title;
        bool isRecommended;

        // Floating point, integral types (sbyte, byte, char etc) https://goo.gl/k7wqDu
        public decimal price;
    }

    enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };

