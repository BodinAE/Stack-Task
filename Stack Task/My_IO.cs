using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Task
{
    internal static class My_IO
    {
        public static int IntInput(string message = "int: ")                //writes a message and checks if inputted value is valid
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

        public static double DoubleInput(string message = "double: ")       //writes a message and checks if inputted value is valid
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

        public static float FloatInput(string message = "float: ")          //writes a message and checks if inputted value is valid
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

        public static string StringInput(string message = "string: ")       //writes a message and checks if inputted value is valid
        {
            Console.Write(message);
            string str = Console.ReadLine();
            return str;
        }

        public static void Output<T>(T output)                              //Outputs a variable into the console
        {
            Console.WriteLine(output);
        }

        public static void Output<T>(T[] output)                            //Outputs an array into the console
        {
            Console.Write("Array: ");
            foreach (var item in output) Console.Write($"{item} ");
        }
    }
}
