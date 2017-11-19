using System;
using System.Linq;

namespace Util
{
    public class Sorter : SortingInterface
    {

        public string[] SortNamesList(string[] unsorted_names_list)
        {
            return unsorted_names_list.OrderBy(line =>
            {
                string[] names = line.Split(' ');
                if (names.Length > 4 || names.Length == 0)
                {
                    Console.Error.WriteLine($"'{line}' Entry is too long!");
                }
                string last_name = names.Last();
                string remaining_names = String.Join(" ", names.Take(names.Length - 1).ToArray());
                return last_name + " " + remaining_names;
            }).ToArray();
        }
    }
}
