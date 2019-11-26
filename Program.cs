using System;

namespace Lab04_Ali
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            {
                for (int i = 1; i < 101; i++)
                {
                    Console.WriteLine(i);
                    {
                        if ((i % 2) == 0)
                        { Console.WriteLine("Number is even"); }
                        else if ((i % 2) != 0)
                        {
                            Console.WriteLine("Number is odd");
                        }
                    }
                }
            }
            {
                Console.Write("Please enter a temperature: "); int temp = Convert.ToInt32(Console.ReadLine()); if (temp >= 90)
                { Console.WriteLine("fish"); }
                else if (temp >= 80)
                { Console.WriteLine("Lion"); }
                else if (temp >= 70)
                { Console.WriteLine("Turle"); }
                else if (temp >= 60)
                { Console.WriteLine("Deer"); }
                else if (temp >= 50)
                { Console.WriteLine("Reindeer"); }
                else if (temp >= 40)
                { Console.WriteLine("Moose"); }
                else if (temp >= 20)
                { Console.WriteLine("Penguin"); }
                else if (temp >= 10)
                { Console.WriteLine("Polar Bear"); }
                else
                {
                    Console.WriteLine("Bug");
                }
            }
            Console.WriteLine("Please enter the exhibit number: "); string str = Console.ReadLine();
            int caseSwitch = int.Parse(str);
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("polar bear "); break;
                case 2:
                    Console.WriteLine("penquin "); break;
                case 3:
                    Console.WriteLine("moose "); break;
                case 4:
                    Console.WriteLine("reindeer "); break;
                case 5:
                    Console.WriteLine("deer "); break;
                case 6:
                    Console.WriteLine("turtle "); break;
                case 7:
                    Console.Write("lion "); break;
                case 8:
                    Console.WriteLine("fish "); break;
                case 9:
                    Console.WriteLine("bug "); break;
            }
        }

    }
}
//*Question 1.  A control variable, changes its value and makes the loop run repetitively.
// An intial value helps the loop start. If the inital value is not known then the loop can't be started.
// Increment or decrement, this can be any integer. Depending if you want to increase or decrease a value
// Loop Continuation, This is used as a delimiter to continue or stop looping.

// Question 2. A "for" and "while" statements are almost the same. They execute the same operation but a "for" 
// statement is a condensed version of a "while" statement.

// Question 3. It would be useful to utilize a do-while statement when something needs to occur, but it won't 
//occur correctly with certainty on the first iteration.The loop will always run at least once with a do-while 
//statement, so if it is preferred that a condition be checked at the end of the loop execution it
//will verify if it should iterate further.

//Question 7. You need to add Console.Write(); at the end after Console.WriteLine(i);

//Question 8. You need to add a "{ }" at the beginning and end

