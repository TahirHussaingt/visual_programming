using System;

namespace VariableDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration and initialization separately
            String userName;
            // Initialize the variable with a value
            userName = "Tahir Hussain";
            //result
            Console.WriteLine("UserName:- " + userName);


            // Declaration and initialization in one line
            int userAge = 25;
            //result
            Console.WriteLine("Age:- " + userAge);


            // Declare and initialize a boolean in one line
            bool isTaskCompleted = true;
            //result
            Console.WriteLine("Boolean: " + isTaskCompleted);
        }
    }
}