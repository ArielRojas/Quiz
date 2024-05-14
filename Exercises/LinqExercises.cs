using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

        public static void ShowFrequency(string word)
        {
            var frequencyCharacter = word.GroupBy(char.ToLower)
                          .Select(counter =>
                          new { 
                              Letter = counter.Key,
                              Counter = counter.Count()
                          });

            foreach (var counter in frequencyCharacter)
            {
                Console.WriteLine(String.Format($"{counter.Letter}, {counter.Counter}"));
            }
        }

        public static void ShowGreatherThanGivenNumber(List<int> list, int number)
        {
            var result = list.Where(x => x > number);

            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }

        public static void ShowStringStartAndEndWithSpecificCharacter(List<string> list, char start, char end)
        {
            var result = list.Where(value => value.StartsWith(start) && value.EndsWith(end));

            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
        }

        public static void FindUppercaseWordsInString(string inputValue)
        {
            var words = inputValue.Split(' ');
            var result = words.Where(word =>
                word.All(character =>
                    char.IsUpper(character)));

            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
        }

        public static void CountFileExtensions(List<string> list)
        {
            var result = list.GroupBy(element => element.ToLower().Split('.')[1])
                          .Select(counter =>
                          new {
                              Extension = counter.Key,
                              Counter = counter.Count()
                          });

            foreach (var counter in result)
            {
                Console.WriteLine($"{counter.Counter} File(s) with .{counter.Extension} Extension");
            }
        }
    }
}
