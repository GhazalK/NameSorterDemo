using System;

using Util;
namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length ==0){
                Console.WriteLine("No file entries!");
            }

            SortingInterface name_sorter = new Sorter();
            IOInterface original_name = new InputFile();
            string[] name_entries = original_name.GetInputName(args[0]);;
            string[] sorted_names = name_sorter.SortNamesList(name_entries);
            foreach (String sorted_name in sorted_names)
            {
                Console.WriteLine(sorted_name);
                System.IO.File.WriteAllLines(@"sorted-names-list.txt", sorted_names);
            }

            Environment.Exit(0);



        }
    }
}
