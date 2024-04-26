namespace Day4
{
    internal class Program
    {
        static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y; 
            y = temp;
        }

        static void Main(string[] args)
        {
            /*Employee e1 = new Employee();

            e1.Salary = 4000; //e1.SetSalary(4000);
            e1.ID = 1;
            int x = e1.Salary; //e1.GetSalary();

            int y = 5;

            Swap(ref x, ref y);

            MyList<int> myList = new MyList<int>();

            myList.Add(1);
            myList.Add(2);
            //myList.Add("sdfds");*/

            IMovable m1 = new Car();
            IMovable m2 = new Human();
            IMovable m3 = new Employee();

            m1.Move();
            Car c = new Car();
            m1.GetSpeed();
            //c.Move();

            //int[] arr = { 8, 6, 5, 4, 3, 2 };
            
            Employee[] emps = new Employee[3];

            emps[0] = new Employee(5);
            emps[1] = new Employee(15);
            emps[2] = new Employee(1);

            emps[0].CompareTo("hello");

            Array.Sort(emps);

            for (int i = 0; i < emps.Length; i++) 
            {
                Console.WriteLine(emps[i].ID);
            }
            
        }
    }
}