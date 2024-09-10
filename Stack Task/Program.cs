namespace Stack_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            My_stack stack1 = new My_stack(My_IO.IntInput("Max count: "));
            My_stack stack2 = new My_stack(stack1);
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("      Menu");
                Console.WriteLine("Press  [1] to push to stack");
                Console.WriteLine("Press  [2] to pop from stack");
                Console.WriteLine("Press  [3] to print stack");
                Console.WriteLine("Press  [4] to refresh stack copy");
                Console.WriteLine("Press  [5] to push to stack copy");
                Console.WriteLine("Press  [6] to pop from stack copy");
                Console.WriteLine("Press  [7] to print stack copy");
                Console.WriteLine("Press  [8] to print average of stack");
                Console.WriteLine("Press  [9] to print average of stack copy");
                Console.WriteLine("Press  [Esc] to exit");
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        stack1.Push(My_IO.IntInput("Push: "));
                        HoldConsole();
                        break;
                    case ConsoleKey.D2:
                        My_IO.Output(stack1.Pop());
                        HoldConsole();
                        break;
                    case ConsoleKey.D3:
                        stack1.Print();
                        HoldConsole();
                        break;
                    case ConsoleKey.D4:
                        stack2 = new My_stack(stack1);
                        break;
                    case ConsoleKey.D5:
                        stack2.Push(My_IO.IntInput("Push: ")); ;
                        HoldConsole();
                        break;
                    case ConsoleKey.D6:
                        My_IO.Output(stack2.Pop());
                        break;
                    case ConsoleKey.D7:
                        stack2.Print();
                        HoldConsole();
                        break;
                    case ConsoleKey.D8:
                        My_IO.Output(stack1.GetAverage());
                        HoldConsole();
                        break;
                    case ConsoleKey.D9:
                        My_IO.Output(stack2.GetAverage());
                        HoldConsole();
                        break;
                    case ConsoleKey.Escape:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Unrecognised key");
                        HoldConsole();
                        break;
                }
            }
        }

        public static void HoldConsole()                                //prevents console from being cleared before pressing a key
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
