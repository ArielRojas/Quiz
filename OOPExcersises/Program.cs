namespace OOPExcersises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyIntStack myIntStack = new MyIntStack();
            myIntStack.Push(1);
            myIntStack.Push(2);
            myIntStack.Push(3);
            myIntStack.Push(4);
            myIntStack.Push(5);

            myIntStack.PrintStack();
            Console.WriteLine($"Pop data: {myIntStack.Pop()}");
            myIntStack.PrintStack();
        }
    }
}
