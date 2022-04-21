// See https://aka.ms/new-console-template for more information
using System;
using _02UnderstandingTypes;

//1. Telephone number: string; Height: byte; Age: byte; Gender: Enum; Salary: decimal;
//   Book's ISBN: string; Price: uint; Shipping weight: float; Population: ulong; Stars in the universe: ulong; Employees: ushort
//2. Difference between value type and reference type:
//   1) Value type will directly hold the value, while reference type will hold the memory address or reference for this value;
//   2) Value types are stored in stack memory, while reference type will be stored in heap memory;
//   3) Value type will not be collected by garbage collector, while reference type will be collected by garbage collector;
//   4) Value type can be created by Struct or Enum, while reference type can be created by class, interface, delegate or array;
//   5) Value type cannot accept null values, while reference type can accept null values.
//   Boxing: Convert a value type to reference type;       Unboxing: Convert a reference type to a value type
//3. Managed resources are those that are pure .NET code and managed by the runtime and are under its direct control.
//   Unmanaged resources are those that are not. File handles, pinned memory, COM objects, database connections etc.
//4. NET's garbage collector manages the allocation and release of memory for your application.

Class1 demo = new Class1();

demo.ConvertTime(1);
demo.ConvertTime(5);

namespace _02UnderstandingTypes
{
    public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("| Type \t|\tBytes of Memory \t|\t Min \t\t\t\t\t|\tMax \t\t\t\t\t|");
        Console.WriteLine($"| sbyte\t|\t {sizeof(sbyte)}\t\t\t|\t {sbyte.MinValue}\t\t\t\t\t|\t{sbyte.MaxValue} \t\t\t\t\t|");
        Console.WriteLine($"| byte \t|\t {sizeof(byte)} \t\t\t|\t {byte.MinValue} \t\t\t\t\t|\t {byte.MaxValue} \t\t\t\t\t|");
        Console.WriteLine($"| short\t|\t {sizeof(short)}\t\t\t|\t{short.MinValue}  \t\t\t\t|\t {short.MaxValue} \t\t\t\t\t|");
        Console.WriteLine($"| ushort|\t {sizeof(ushort)} \t\t\t|\t {ushort.MinValue} \t\t\t\t\t|\t {ushort.MaxValue} \t\t\t\t\t|");
        Console.WriteLine($"| int \t|\t {sizeof(int)} \t\t\t|\t {int.MinValue} \t\t\t\t|\t {int.MaxValue} \t\t\t\t|");
        Console.WriteLine($"| uint \t|\t {sizeof(uint)} \t\t\t|\t {uint.MinValue} \t\t\t\t\t|\t {uint.MaxValue} \t\t\t\t|");
        Console.WriteLine($"| long \t|\t {sizeof(long)} \t\t\t|\t {long.MinValue} \t\t\t|\t {long.MaxValue} \t\t\t|");
        Console.WriteLine($"| ulong\t|\t {sizeof(ulong)} \t\t\t|\t {ulong.MinValue} \t\t\t\t\t|\t {ulong.MaxValue} \t\t\t|");
        Console.WriteLine($"| float\t|\t {sizeof(float)} \t\t\t|\t {float.MinValue} \t\t\t|\t {float.MaxValue} \t\t\t\t|");
        Console.WriteLine($"| double|\t {sizeof(double)} \t\t\t|\t {double.MinValue} \t\t|\t{double.MaxValue} \t\t|");
        Console.WriteLine($"| decimal|\t {sizeof(decimal)} \t\t\t|\t {decimal.MinValue} \t|\t{decimal.MaxValue} \t\t|");
    }
}

}




