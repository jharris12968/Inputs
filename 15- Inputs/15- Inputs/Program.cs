using System.Runtime.CompilerServices;

namespace _15__Inputs
{
    internal class Program
    {
        //static int[] totals = new int[10]; //Commented out per last instruction
        static List<int> totals = new List<int>(); //Initializes a list to replace the array that is commented out 
        
        static void Main(string[] args)
        {
            //Setting both variables = 0 avoids null warning
            int valid = 0; 
            int invalid = 0;

            Console.WriteLine("Welcome to the Valid Inputs Program");

            for (int i = 0; i < 10; i++) //Sets the program to loop 10 for 10 inputs
            {
                Console.WriteLine("Please enter a value between 0 and 10");

                string input = Console.ReadLine(); //Stores the users input within the Array using a string

                if (int.TryParse(input, out int value)) //Takes the "input" and stores it as an int and outputs the value "1" for everything inside and "1" for everything outside.
                {
                    if (value >= 0 && value <= 10) //Accepts every input 0-10 and corresponds with the "valid" int
                    {
                        //totals[value]++; //"totals" for the method
                        ListTotal(value); //Calls to the method supporting the list
                        valid++;
                    }
                    else //Rejects every input outside of 0-10, including alphabetic characters, and corresponds with the "invalid" int
                    { 
                        invalid++;
                    }
                }
                else
                {
                    invalid++;
                }
            }
            //Totals output here
            Console.WriteLine("The total valid entries were: " + valid);
            Console.WriteLine("The total invalid entries were: " + invalid);
        }
        
        //Method for list per instructions
        static void ListTotal(int value) //Static method set within the same class for the list to be called upon
        {
            while (totals.Count < value +1) //The while loop adds a line "+1" until it reach the end of the range set for the value
            {
                totals.Add(0); //This adds the user input from zero every time it is looped
            }
            totals[value]++; //This sends the information from the user inputs because [value] is the parameter of the totals i.e the list.
        }
    }
}
