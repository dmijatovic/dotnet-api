using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Dusan";
            int age = 20;
            string test = "I am {0} testing it {1}";
            // write line to console
            Console.WriteLine(test,name,age);
            // read input from console
            string resp = Console.ReadLine();
            if (resp=="test"){
                Console.WriteLine("Yes we will test...");
            }else{
                Console.WriteLine("You did not types test");
            }
        }
    }
}
