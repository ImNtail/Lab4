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
			switch (select) {
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
					third();
					break;
				case 4:
					Console.WriteLine("The fourth task: \n");
					fourth();
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
			switch (way) {
				case "array":
					first_way();
					break;
				case "string":
					second_way();
					break;
			}
			Console.ReadKey();
		}
		static void first_way()
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
        static void second_way()
        {
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine().ToLower();
            for (int i = 0; i < s.Length; i++)
            {
            	if (s.IndexOf(s[i]) == s.LastIndexOf(s[i]))
            		Console.Write(s[i] + " ");
            }
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
                default:
                    break;
            }
            Console.ReadKey();
        }
        static void first_way_2()
        {
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
            	int counter = i + 1;
            	if (s[i] == ' ' || s[i] == ',' || s[i] == '-' || s[i] == '.')
            	    Console.Write(s[i]);
            	else
            	Console.Write("{0}({1})", s[i], counter);
            }
            //Выводит число после каждой буквы. Как исправить?
            Console.WriteLine();
        }
        static void second_way_2()
        {
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            string[] words = s.Split(new char[] { ' ', ',', '-', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int counter = 1;
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Insert(words[i].Length, "(" + (counter) + ")");
                counter++;
            }
            foreach (String str in words)
            	Console.Write(str);
            Console.WriteLine();
            //Выводит слова подряд без разделения. Числа указываются правильно. Как расставить знаки, как в начальном предложении?
        }
        
        /*
        3. Ввести текст из нескольких слов, завершить точкой. Сформировать новую
		строку на основе исходной путем перестановки слов в обратной
		последовательности. Решить задачу 2 способами: через обработку строки
		как массива символов и с помощью методов классов string и StringBuilder.
		*/
		static void third()
		{
			Console.Write("Choose the way (Enter \"array\" or \"string\"): ");
            string way = Console.ReadLine();
            switch (way)
            {
                case "array":
                    first_way_3();
                    break;
                case "string":
                    second_way_3();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
		}
		static void first_way_3()
        {
		 	Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            int counterOfwords = 0;
            foreach (char ch in s)
            {
            	if (ch == ' ')
            		counterOfwords++;
            }
            char[] chars = s.ToCharArray();
            string[] output = new string[counterOfwords+1];
            for (int i = 0; i < output.Length; i++)
            {
            	for (int j = 0; j < chars.Length; j++)
            	{
            		output[i] += chars[j];
            		if (chars[j] == ' ')
            		{
            			break;
            		}
            	}
            }
            Array.Reverse(output);
            for (int i = 0; i < output.Length; i++)
            {
            	Console.Write(output[i] + " ");
            }
            //Выводит в обратном порядке, столько слов, сколько нужно, но все слова - первое слово. Как пропускать использованный пробел?
		}
		static void second_way_3()
        {
			Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            string[] str = s.Split(new char[] {' ', '.'}, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(str);
            for (int i = 0; i < str.Length; i++)
            {
            	if (i == str.Length-1)
            		Console.Write(str[i] + ".");
            	else
            		Console.Write(str[i] + " ");
            }
		}
		
		/*4. Ввести с клавиатуры 7 строк, занести их в массив. Вывести все строки, в
		которых содержится хотя бы одно слово, оканчивающееся на “.com”
		(регистр символов не важен; слова разделяются пробелами, запятыми или
		точками). Также вывести номер строки, содержащей наименьшее число
		пробелов. Решить 2 способами: через обработку строки как массива
		символов и с помощью методов класса string.
		*/
		static void fourth()
		{
			Console.Write("Choose the way (Enter \"array\" or \"string\"): ");
            string way = Console.ReadLine();
            switch (way)
            {
                case "array":
                    first_way_4();
                    break;
                case "string":
                    second_way_4();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
		}
		static void first_way_4()
        {
			int length = 7, number;
			string[] s = new string[length];
			for (int i = 0; i < s.Length; i++)
			{
				number = i+1;
				Console.Write(number + ". ");
			 	Console.WriteLine("Enter the string: ");
			 	s[i] = Console.ReadLine();
			}
			
		}
		static void second_way_4()
        {
			Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();

		}
    }
}
