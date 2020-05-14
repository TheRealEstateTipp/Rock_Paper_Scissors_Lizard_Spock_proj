using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        Random random = new Random();

        public override void playername()
        {
            Console.WriteLine("computer");
        }

        public override void Gestures()
        {
            int index = random.Next(listofgestures.Count);
            Console.WriteLine(listofgestures[index]);

        }
    }
}
