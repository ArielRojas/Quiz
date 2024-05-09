using System.ComponentModel;

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

            Console.WriteLine("List in Ascending order:");
            LinqExercises.ShowInAscendingOrder(list);

            List<char> listChars = new List<char>();
            listChars.Add('m');
            listChars.Add('n');
            listChars.Add('o');
            listChars.Add('p');
            listChars.Add('q');

            Console.WriteLine("Remove range from list:");
            LinqExercises.RemoveRangeItems(listChars);
        }
    }
}
