using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //Member Variables
        public string PlayerName;
        public List<string> Gesture = new List<string>{ ("Rock"), ("Paper"), ("Scissor"), ("Lizard"), ("Spock") };


        
       

        public virtual void playername()
        {
            Console.WriteLine("Please Enter Player's Name");
            string userInput = Console.ReadLine();
        }

        public abstract void Gestures();



    }
}
