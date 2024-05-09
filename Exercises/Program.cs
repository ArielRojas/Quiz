namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Biscuit");
            list.Add("Honey");
            list.Add("Brade");
            list.Add("Butter");

            LinqExercises.ShowInAscendingOrder(list);
        }
    }
}
