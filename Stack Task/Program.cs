namespace Stack_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            My_list test = new My_list(1);
            test.AddTailNode(2);
            test.AddTailNode(3);
            My_list test2 = test.Copy();
            My_IO.Output(test2.GetHeadNode());
            My_IO.Output(test2.GetTailNode());
        }
    }
}
