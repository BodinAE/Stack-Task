using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Task
{
    internal static class My_IO
    {
        public static int IntInput(string message = "int: ")
        {
            bool success = false;
            int num = 0;
            while (!success)
            {
                Console.Write(message);
                success = Int32.TryParse(Console.ReadLine(), out num);
                if (!success) Console.WriteLine("Не целочисленное число");
            }
            return num;
        }

        public static double DoubleInput(string message = "double: ")
        {
            bool success = false;
            double num = 0;
            while (!success)
            {
                Console.Write(message);
                success = Double.TryParse(Console.ReadLine(), out num);
                if (!success) Console.WriteLine("Не число");
            }
            return num;
        }

        public static float FloatInput(string message = "float: ")
        {
            bool success = false;
            float num = 0;
            while (!success)
            {
                Console.Write(message);
                success = float.TryParse(Console.ReadLine(), out num);
                if (!success) Console.WriteLine("Не число");
            }
            return num;
        }

        public static string StringInput(string message = "string: ")
        {
            Console.Write(message);
            string str = Console.ReadLine();
            return str;
        }

        public static void Output<T>(T output)
        {
            Console.WriteLine(output);
        }

        public static void Output<T>(T[] output)
        {
            Console.Write("Array: ");
            foreach (var item in output) Console.Write($"{item} ");
        }
    }
}
