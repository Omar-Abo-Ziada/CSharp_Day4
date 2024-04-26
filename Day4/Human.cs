using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Human : Creature, IMovable
    {
        public override void Move()
        {
            Console.WriteLine("Human is moving..");
        }
    }
}
