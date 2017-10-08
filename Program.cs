using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)                                                                     // This is a method called "Main". It is called when the programstarts.
        {
        Start:
           double num01;
           double num02;
           

           Console.WriteLine ("MULTIPLICATION CALCULATOR");
           Console.Write ("Type a number: ");
           num01 = Convert.ToDouble (Console.ReadLine ());
           Console.Write ("Type another number to be multiplied: ");
           num02 = Convert.ToDouble (Console.ReadLine ());
           Console.WriteLine (num01 + " multiplied by " + num02 + " equals " + num01 * num02);

                                                                                                            // This loops user back to start of calculator.
           Console.ReadKey ();
           Console.WriteLine(); 
           goto Start;
        }
    }
}
