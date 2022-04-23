// See https://aka.ms/new-console-template for more information
//1.Public: The type or member can be accessed by any other code in the same assembly or another assembly that references it.
//  Private: The type or member can be accessed only by code in the same class or  struct
//  Protected:The type or member can be accessed only by code in the same  class , or in a class that is derived from that class .
//  Internal: The type or member can be accessed by any code in the same assembly, but not from another assembly.
//  Protected internal: The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived  class  in another assembly.
//  Private protected: The type or member can be accessed by types derived from the class that are declared within its containing assembly
//2. static: this member belong to the type itself, rather than any objects from the specific type
//   const: the member is a constant
//   readonly: we use readonly to modify a variable, and once we assign the value to the read - only member, the value cannot be changed
//3. Constructor: create an object of the class and initialize class members
//4. Partial keyword: It is possible to split the definition of a class, a struct, an interface or a method over two or more source files
//5. Tuple: Tuple is a data type that we can group multiple data elements together.
//6. Record keyword: Record is a reference type in C#, and it's primarily intended for supporting immutable data models.
//7. Overloading: compile-time polymorphism. It allows methods in the same class share the same name but different parameter lists
//   Overriding: run-time polymorphism. Happens between base class and sub class, where subclass can have different implementation for the methods. 
//8. Difference between a field and a property: Field stores the data of specific information that we want to keep for certain object, usually we should set fields as private.
//                                              Property is a private data field plus get and set accessor, so that we can encapsulate our data
//9. How to make a method parameter optional: give the parameter the default value.
//10. Interface: s a collection of methods which are by default abstract and public and will be implemented by the derived class
//    Abstract class vs. Interface:
//    1) abstract class provides a base class to its subclasses -- clear class hierachy interface defines common behaviros or functionalities that can be implemented by any class --contract
//    2) one class can only inherit from one abstract class, but one class can implement multiple interfaces
//    3) Methods in abstract class can be abstract methods or non-abstract methods, but methods in interfaces are by default abstract and public
//11. What accessibility level are members of an interface: by default public
//12. Polymorphsim allows derived classes to provide different implementations of the same method.
//13. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
//14. false
//15. Abstract methods cannot be used in a normal (non-abstract) class.
//16. Normal (non-abstract) methods can be used in an abstract class
//17. Derived classes can override methods that were virtual in the base class.
//18. Derived classes MUST override the abstract methods from the base class.
//19. In a derived class, you can only override virtual or abstct methods.
//20. A class that implements an interface has to provide an implementation for all of the members of the interface.
//21. A class that implements an interface is allowed to have other members that aren’t defined in the interface.
//22. In C#, we only have single inheritance.
//23. A class can implement more than one interface.
using ObjectOrientedProgramming;

Class1 demo = new Class1();

//int[] numbers = demo.GenerateNumbers(5);
//demo.Revese(numbers);
//demo.PrintNumbers(numbers);


