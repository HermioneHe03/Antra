// See https://aka.ms/new-console-template for more information
using System;
using Exercise03;
//1. Divide an int variable by 0: Compile time error: System.DivideByZeroException:“Attempted to divide by zero.”.
//2. Divide a double variable by 0: Output is positive infinity.
//3. Overflow an int variable: Compile time error: cannot explicitly convert uint type to int type.
//4. Difference between x=y++ and x=++y: In x = y++: y will be assigned to x and then y will be incremented; 
//                                       In x = ++y: y will be incremented and then the result will be assigned to x.
//5. break: End the whole loop and continue executing after the loop;
//   continue: End the current iteration of the loop and continue executing at the start of the loop block for the next iteration;
//   return: End the current method call and continue executing after the method call.
//6. Three part of a for statement: initializer, condition, incrementer. The condition is required, the other two are optional.
//7. Difference between = and ==: "=" is the assignment operator for assigning values to variables.
//                                "==" is the equality check operator that returns true or false.
//8. for(; true;); could compile.
//9. "_" is used to represent the default return value.
//10. Enumerable must an object implement to be enumerated over by using the foreach statement.
Class1 demo = new Class1();
//demo.FizzBuzzis();
//demo.Test2();
// Test2 cannot compile. If "WriteLine" turn to "Console.WriteLine", the output will be infinite loop. If we don't want the infinite loop, "byte i" should be insteaded of "int i".

//demo.GuessNumber();
//demo.PrintaPyramid(12);
//demo.DaysOld();
//demo.Greetings();
demo.CountByIncrement();