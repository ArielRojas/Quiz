using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class LinqExercises
    {
        public static void ShowInAscendingOrder(List<string> list)
        {
            var elementsInAscendingOrder = list.OrderBy(element => element).ToList();

            foreach (var element in elementsInAscendingOrder)
            {
                Console.WriteLine(element);
            }
        }

        public static void RemoveRangeItems(List<char> list)
        {
            list.RemoveRange(1, 3);

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
