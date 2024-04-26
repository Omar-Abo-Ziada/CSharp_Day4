using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal interface IMovable
    {
        void Move();
        //public int Speed { get; set; }

        int GetSpeed()
        {
            return 0;
        }
    }
}
