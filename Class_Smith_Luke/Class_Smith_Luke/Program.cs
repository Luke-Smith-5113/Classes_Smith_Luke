using System;

namespace Classes_Smith_Luke
{
    //public class
    class Greetings
    {
        //method
        public void Howdy()
        {
            //says howdy
            Console.WriteLine("Howdy");
        }
        //method
        public void Hello(string name)
        {
            //prints a greeting
            Console.WriteLine($"{name}, thank you for joining us today!");
        }
    }
    //other class
    class Program
    {
        //method
        static void Main(string[] args)
        {
            //creates greet object
            Greetings myGreet = new Greetings();
            //runs myGreet.Howdy
            myGreet.Howdy();
            //asks for a name
            Console.WriteLine("What's your name?");
            //takes the name as string
            string nameName = Console.ReadLine();
            //runs myGreet.NameGreet
            myGreet.Hello(nameName);
        }
    }
}
