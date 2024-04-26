using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Car : IMovable, ITestable, IReplacable
    {
        //public void Move()
        //{
        //    Console.WriteLine("Car is moving..");
        //}

        void IMovable.Move()
        {
            Console.WriteLine("Car is moving..");
        }

        void ITestable.Foo()
        {

        }

        void IReplacable.Foo()
        {

        }

        public void Foo()
        {

        }
    }
}
