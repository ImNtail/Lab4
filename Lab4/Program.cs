using System;
namespace Lab4_SD
{
    class Program
    {
        static void Main(string[] args)
        {
            int select;
            Console.Write("Choose the task from 1 to 10: ");
            select = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (select)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("The first task: \n");
                    first();
                    break;
                case 2:
                    Console.WriteLine("The second task: \n");
                    second();
                    break;
                case 3:
                    Console.WriteLine("The third task: \n");
                    //                    third();
                    break;
                case 4:
                    Console.WriteLine("The fourth task: \n");
                    //                    fourth();
                    break;
                case 5:
                    Console.WriteLine("The fifth task: \n");
                    //                    fifth();
                    break;
                case 6:
                    Console.WriteLine("The sixth task: \n");
                    //                    sixth();
                    break;
                case 7:
                    Console.WriteLine("The seventh task: \n");
                    //                    seventh();
                    break;
                case 8:
                    Console.WriteLine("The eighth task: \n");
                    //                    eighth();
                    break;
                case 9:
                    Console.WriteLine("The first individual task: \n");
                    //                    ninth();
                    break;
                case 10:
                    Console.WriteLine("The second individual task: \n");
                    //                    tenth();
                    break;
                default:
                    break;
            }
        }


        /*
  		1. Ввести с клавиатуры текст предложения, завершить точкой. Вывести на
		консоль все символы, которые входят в этот текст ровно по одному разу.
		Решить задачу 2 способами: через обработку строки как массива символов и
		с помощью методов класса string.
		 */
        static void first()
        {
            Console.Write("Choose the way (Enter \"array\" or \"string\"): ");
            string way = Console.ReadLine();
            switch (way)
            {
                case "array":
                    first_way_1();
                    break;
                case "string":
                    second_way_1();
                    break;
            }
            Console.ReadKey();
        }
        static void first_way_1()
        {
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine().ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                int n = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (s[i] == s[j])
                        n++;
                }
                if (n == 0)
                    Console.Write(s[i] + " ");
            }
        }
        static void second_way_1()
        {
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine().ToLower();
            string new_s = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (new_s.Contains(s[i]))
                    new_s.Remove(new_s.LastIndexOf(s[i]));
                else
                    new_s += s[i];
            }
            foreach (char ch in new_s)
                Console.Write(ch + " ");
        }

        /*
		2. Ввести с клавиатуры текст предложения, завершить точкой. Сформировать
		новую строку на основе исходной, в которой после каждого слова в скобках
		указать номер слова в предложении (слова разделяются запятыми,
		пробелами или тире). Например, если введено «Донецк – прекрасный
		город», результирующая строка должна выглядеть так: «Донецк(1) –
		прекрасный(2) город(3)». Решить задачу 2 способами: через
		обработку строки как массива символов и с помощью методов класса string.
		 */
        static void second()
        {
            Console.Write("Choose the way (Enter \"array\" or \"string\"): ");
            string way = Console.ReadLine();
            switch (way)
            {
                case "array":
                    first_way_2();
                    break;
                case "string":
                    second_way_2();
                    break;
            }
            Console.ReadKey();
        }
        static void first_way_2()
        {
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            string[] words = s.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int i = 1;
            foreach (string word in words)
            {
                Console.Write("{0}({1}) ", word, i);
                i++;
            }
            Console.WriteLine();
        }
        static void second_way_2()
        {
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            string[] words = s.Split(new char[] { ' ', '.', ',', ':', '!', '?', '-', '_', ')', '(' }, StringSplitOptions.RemoveEmptyEntries);
            int i = 1;
            foreach (string word in words)
            {
                Console.Write("{0}({1}) ", word, i);
                i++;
            }
            Console.WriteLine();
        }
    }
}