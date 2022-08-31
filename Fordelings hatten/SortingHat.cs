using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fordelings_hatten
{
    internal class SortingHat
    {
        public SortingHat()
        {
            //variable
            int dorm = 0;
            string dorms = "";
            string trades = "";
            string yesNo = "";
            bool sortingDone = false;


            //Random that sets the dorm to a random number between 0 and 3
            Random random = new Random();
            dorm = random.Next(0, 4);

            do
            {
                //clear the consloe
                Console.Clear();

                //output to the user
                Console.WriteLine("Welcome to Hogwarts!");
                Console.WriteLine("Lads get you yongsters sortet in to your dorms");
                Console.WriteLine("are you ready (y/n)");
                yesNo = Console.ReadLine().ToLower();

                //if the user is ready to get sortet in to their dorms
                //else wipe their memory
                if (yesNo == "y")
                {
                    //the random takes a number
                    //inside the if the value from enum is used
                    //the trade variable gets updatet
                    //sortingDone is set to true
                    if (dorm == 0)
                    {
                        dorms = ((Dorm)0).ToString();
                        trades = "you are brave and strong";
                        sortingDone = true;
                    }
                    else if (dorm == 1)
                    {
                        dorms = ((Dorm)1).ToString();
                        trades = "you are loyal and brave";
                        sortingDone = true;
                    }
                    else if (dorm == 2)
                    {
                        dorms = ((Dorm)2).ToString();
                        trades = "you are inquisitive and intelligent";
                        sortingDone = true;
                    }
                    else
                    {
                        dorms = ((Dorm)3).ToString();
                        trades = "you are conning, determined and will stop at nothing to achieve your goals";
                        sortingDone = true;
                    }
                    Console.WriteLine($"You made it to {dorms}, because {trades}!");
                }
                else
                {
                    Console.WriteLine("OBLIVIATE!!!!");
                }
                //waiting 2 seconds at start the loop again
                Thread.Sleep(2000);

            } while (sortingDone != true);
        }
    }
}
