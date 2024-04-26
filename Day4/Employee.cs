using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Employee : Human, IComparable<Employee>
    {
        //private int id;
        private int salary;

        //public int ID
        //{
        //    get
        //    {
        //        return id;
        //    }
        //    set
        //    {
        //        id = value;
        //    }
        //}

        public int ID { get; set; }

        public int Salary
        {
            get
            {
                return salary;
            }

            set
            {
                if (value > 3000)
                    this.salary = value;
            }
        }
        public Employee()
        {
        }

        public Employee(int id)
        {
            this.ID = id;
            //Salary = 10;
        }

        //public int CompareTo(object obj)
        public int CompareTo(Employee emp)
        {

            //if (this.ID > emp.ID)
            //    return 1;

            //if (this.ID < emp.ID)
            //    return -1;

            //return 0;
            
            return this.ID.CompareTo(emp.ID);
        }
    }
}
