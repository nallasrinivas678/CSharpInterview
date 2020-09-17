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


    //Struct vs class

    //In .NET, there are two categories of types, reference types and value types.

    //Structs are value types and classes are reference types.

    //The general difference is that a reference type lives on the heap, 
    //and a value type lives inline, that is, wherever it is your variable or field is defined.

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


/// <summary>
////The limitations of structs include:
////Only static or const fields can be initialized during declaration.
////You cannot declare a finalizer, a.k.a. parameterless constructor.
////Structs are copied on assignment.
////Structs are value types, while classes are reference types.
////Structs can have constructors that accept parameters.
////Structs cannot inherit from another struct or class. They inherit from value types, which inherit from object types.
////Structs can have interfaces.
////Structs cannot be null, meaning they cannot assign any of their variables the null value unless they are declared as nullable.
/// </summary>

//Sample struct
public struct Device
{
    public string DeviceType { get; set; }
    public string Name { get; set; }
    public int Serial { get; set; }
    public Device(string devicetype, string name, int serial)
    {
        DeviceType = devicetype;
        Name = name;
        Serial = serial;
    }
}

enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };

