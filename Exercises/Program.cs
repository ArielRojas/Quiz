using System.ComponentModel;
using System.Net;

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

            Console.WriteLine("Frequency character:");
            string word = "apple";
            LinqExercises.ShowFrequency(word);

            List<int> listInteger = new List<int>();
            listInteger.Add(10);
            listInteger.Add(48);
            listInteger.Add(52);
            listInteger.Add(94);
            listInteger.Add(63);
            Console.WriteLine("Greather than:");

        }
    }
}
