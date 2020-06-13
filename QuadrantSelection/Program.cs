using System;

namespace QuadrantSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quadrant Selection
            // https://open.kattis.com/problems/quadrant

            var xCoordinate = EnterNum();
            var yCoordinate = EnterNum();

            Console.WriteLine(Quadrant(xCoordinate, yCoordinate));
        }

        private static int Quadrant(int a, int b)
        {
            if (a > 0 && b > 0)
                return 1;
            else if (a > 0 && b < 0)
                return 4;
            else if (a < 0 && b < 0)
                return 3;
            else return 2;
        }

        private static int EnterNum()
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
                if (Conditions(a) == false)
                    throw new ArgumentException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString());
                return EnterNum();
            }
            return a;
        }
        private static bool Conditions(int a)
        {
            if ((a != 0) && (a >= -1000) && (a <= 1000))
                return true;
            else
                return false;
        }
    }
}
