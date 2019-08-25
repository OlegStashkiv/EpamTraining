using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Partial_Task4
{
    class Task3 : IRun
    {
        List<string> line_list = new List<string>();

        public void NewRandomList()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChars = new char[4];
            var random = new Random();

            for (int i = 0; i < 100; i++)
            {

                for (int j = 0; j < stringChars.Length; j++)
                {
                    stringChars[j] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);
                line_list.Add(finalString);

            }

            Console.WriteLine(line_list.Count);
        }

        public void UpdateRandomList()
        {
            HashSet<string> new_line_list = new HashSet<string>(line_list);
            List<string> without_z_line_list = new List<string>();

            foreach (var s in new_line_list)
            {
                if (!s.StartsWith("Z"))
                {
                    without_z_line_list.Add(s);
                }
            }

            line_list = without_z_line_list;
            line_list.Sort();
            line_list.Reverse();
            Console.WriteLine(line_list.Count);
        }

        public void DisplayPage(int PageNumber)
        {
            const int page_item = 5;
            int number_page = line_list.Count / page_item;

            if (PageNumber <= 0 || PageNumber > number_page)
            {
                Console.WriteLine("Найденої сторiнки не iснує. Введiть iншу сторiнку.");
                PageNumber = validationDisplayPage();
            }
            
            for (int i = (PageNumber - 1) * page_item; i < (PageNumber * page_item); i++)
            {
                Console.WriteLine(line_list[i]);
            }
        }

        public void Run()
        {
            NewRandomList();
            UpdateRandomList();
            validationDisplayPage();            
        }

        public int validationDisplayPage()
        {
            int PageNumber;
            do
            {
                try
                {
                    PageNumber = Convert.ToInt32(Console.ReadLine());
                    PageNumber = Convert.ToInt32(PageNumber);
                    break;
                }
                catch
                {
                    System.Environment.Exit(0);
                }
            }
            while (true);

            DisplayPage(PageNumber);

            return PageNumber;
        }
    }
}
