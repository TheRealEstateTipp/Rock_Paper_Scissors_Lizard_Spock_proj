using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {

        public override void Gestures()
        {
           Console.WriteLine("Please select your gesture");
            gesture = Console.ReadLine();

            switch (gesture)
            {
                case "Rock":
                    Console.WriteLine(gesture);
                    break;
                case "Paper":
                    Console.WriteLine(gesture);
                    break;
                case "Scissors":
                    Console.WriteLine(gesture);
                    break;
                case ("Lizard"):
                    Console.WriteLine(gesture);
                    break;
                case ("Spock"):
                    Console.WriteLine(gesture);
                    break;
                default:
                    Console.WriteLine("You have entered an incorrect selection. This entry is case sensitive");
                    break;
            }
    }

   



                    

            }
        }
    

