// ClassLibrary -- in a Class Library project

// File: Program.cs in ClassLibraryDriver project
// ClassLibrary -- A simple class library and its driver program
using System;
namespace ClassLibrary
{
    public class MyLibrary
    {
        public void LibraryFunction1()
        {
            Console.WriteLine("This is LibraryFunction1()");
        }
        public static int LibraryFunction2(int input)
        {
            Console.WriteLine("This is LibraryFunction2(), returning {0}", input);
            return input;  // Just parrot the input.
        }
    }
}
