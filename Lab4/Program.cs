using System;
using System.Text.RegularExpressions;

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
					fifth();
					break;
				case 6:
					Console.WriteLine("The sixth task: \n");
					sixth();
					break;
				case 7:
					Console.WriteLine("The seventh task: \n");
					seventh();
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
        	int counter = 0;
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
            	if (Char.IsLetter(s[i]) && (s[i+1] == ' ' || s[i+1] == '-' || s[i+1] == '.' || s[i+1] == ','))
            	{
            		Console.Write("{0}({1})", s[i], ++counter);
            	}
            	else
            	{
            		Console.Write(s[i]);
            	}
            }
            Console.WriteLine();
        }
        static void second_way_2()
        {
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            string[] words = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int counter = 1;
            for (int i = 0; i < words.Length; i++)
            {
            	if (words[i].EndsWith(",") || words[i].EndsWith("."))
            	{
                	words[i] = words[i].Insert(words[i].Length, "(" + (counter) + ")");
            	}
            	else if (words[i] == "-" || words[i] == " ") continue;
            	else
            	{
            		words[i] = words[i].Insert(words[i].Length, "(" + (counter) + ") ");
            	}
                counter++;
            }
            foreach (String str in words)
            	Console.Write(str);
            Console.WriteLine();
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
            char[] tempChars = s.ToCharArray();
            string[] output = new string[counterOfwords+1];
            for (int i = 0; i < output.Length; i++)
            {
            	for (int j = 0; j < tempChars.Length; j++)
            	{
            		output[i] += tempChars[j];
            		if (tempChars[j] == ' ')
            		{
            			Array.Clear(tempChars, 0, tempChars.Length);
            			Array.Copy(chars, j + 1, tempChars, 0, tempChars.Length - j - 1);
            			for (int q = j + 1; q < tempChars.Length; q++)
            			{
            				chars[q] = tempChars[q];
            			}	
            			break;
            		}
            	}
            }
            Array.Reverse(output);
            for (int i = 0; i < output.Length; i++)
            {
            	Console.Write(output[i] + " ");
            }
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
			foreach (string str in s)
			{
				str.ToLower();
				char[] chars = str.ToCharArray();
				Console.WriteLine();
				for (int i = 0; i < str.Length; i++)
				{
					if (chars[i] == '.' && chars[i+1] == 'c' && chars[i+2] == 'o' && chars[i+3] == 'm' && chars[i+4] == ' ' || chars[i+4] == '.' || chars[i+4] == ',' || chars[i+4].Equals(""))
					{
						Console.WriteLine(str);
					}
				}
			}
			//как сделать, чтоб не выдавало OutOfRange
		}
		static void second_way_4()
        {
			int length = 7, number;
			string[] s = new string[length];
			string[] sLower = new string[length];
			for (int i = 0; i < s.Length; i++)
			{
				number = i+1;
				Console.Write(number + ". ");
			 	Console.WriteLine("Enter the string: ");
			 	s[i] = Console.ReadLine();
			 	Console.WriteLine();
			 	sLower[i] = s[i].ToLower();
			}
			Console.WriteLine();
			Console.WriteLine("Strings that contains \".com\":\n");
			for (int i = 0; i < sLower.Length; i++)
			{
				if (sLower[i].EndsWith(".com"))
				{
					number = i+1;
					Console.Write(number + ". ");
					Console.WriteLine(s[i] + "\n");
				}
			}
			Console.WriteLine();
			int spaces = s[0].LastIndexOf(" ");
			int numOfStr = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (spaces > s[i].LastIndexOf(" "))
				{
				    spaces = s[i].LastIndexOf(" ");
				    numOfStr = i;
			    }
			}
			Console.WriteLine("String with the smallest number of spaces: ");
			Console.WriteLine(s[numOfStr]);
			//непонятно что произошло, работает криво
		}
		
		/*5. Ввести с клавиатуры текст. Программно найти в нем и вывести отдельно все
		слова, которые начинаются с большого латинского символа (от A до Z) и
		заканчиваются 2 цифрами, например «Petr93», «Johnny70», «Service02».
		Решить 2 способами: через обработку строки как массива и с помощью
		регулярных выражений.
		*/
		static void fifth()
		{
			Console.Write("Choose the way (Enter \"array\" or \"regular\"): ");
            string way = Console.ReadLine();
            switch (way)
            {
                case "array":
                    first_way_5();
                    break;
                case "regular":
                    second_way_5();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
		}
		static void first_way_5()
        {
			Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            Console.WriteLine();
			string[] words = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < words.Length; i++) 
			{
				string word = words[i];
				if (Char.IsUpper(word[0]) && Char.IsNumber(word[word.Length - 1]) && Char.IsNumber(word[word.Length-2])) 
				{
					Console.WriteLine(words[i]);
				}
			}
		}
		static void second_way_5()
        {
			Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            Console.WriteLine();
            Regex regex = new Regex(@"\b[A-Z](\w*)+\d{2}\b");
			MatchCollection words = regex.Matches(s);
			if (words.Count > 0)
			{
				foreach (Match match in words)
					Console.WriteLine(match.Value);
			}
			else
			{
				Console.WriteLine("There is no such words.");
			}
		}
		
		/*
		6. Ввести строку вида « 15 + 36 = 51 » (количество пробелов может быть
		разным, числа – целые и могут быть отрицательны). С помощью регулярных
		выражений разобрать эту строку и занести в переменные типа int оба
		операнда и сумму. Вывести все переменные на консоль.
		*/
		static void sixth()
		{
			Console.WriteLine("Enter the string such as «15 + 36 = 51»: ");
			string s = Console.ReadLine();
			Regex numbers = new Regex(@"(-?\d)[+*/-]|[()]|(-?[\d.]+)");
			MatchCollection nums = numbers.Matches(s);
			foreach (Match match in nums)
			{
				int num = int.Parse(match.Value);
				Console.Write(num + "  ");
			}
			Console.ReadKey();
		}
		
		/*
		7. Дан треклист – массив из 10 строк следующего вида:
		1. Gentle Giant – Free Hand [6:15]
		2. Supertramp – Child Of Vision [07:27]
		3. Camel – Lawrence [10:46]
		4. Yes – Don’t Kill The Whale [3:55]
		5. 10CC – Notell Hotel [04:58]
		6. Nektar – King Of Twilight [4:16]
		7. The Flower Kings – Monsters & Men [21:19]
		8. Focus – Le Clochard [1:59]
		9. Pendragon – Fallen Dream And Angel [5:23]
		10. Kaipa – Remains Of The Day (08:02)
		Написать программу, которая обрабатывает весь треклист, суммирует время
		звучания песен и выводит результат на экран, а также отображает самую
		длинную и самую короткую песню в списке и пару песен с минимальной
		разницей во времени звучания.
		*/
		static void seventh()
		{
			string[] trackList = new string[10];
			trackList[0] = "Gentle Giant – Free Hand [06:15]";
			trackList[1] = "Supertramp – Child Of Vision [07:27]";
			trackList[2] = "Camel – Lawrence [10:46]";
			trackList[3] = "Yes – Don’t Kill The Whale [03:55]";
			trackList[4] = "10CC – Notell Hotel [04:58]";
			trackList[5] = "Nektar – King Of Twilight [04:16]";
			trackList[6] = "The Flower Kings – Monsters & Men [21:19]";
			trackList[7] = "Focus – Le Clochard [01:59]";
			trackList[8] = "Pendragon – Fallen Dream And Angel [05:23]";
			trackList[9] = "Kaipa – Remains Of The Day [08:02]";
			int digitMin = 0;
			int digitSec = 0;
			decimal sum = 0;
			int[] duration = new int[trackList.Length];
			int minDuration = 0, maxDuration = 0;
			foreach (string str in trackList)
			{
				Console.WriteLine(str);
				Console.WriteLine();
				Regex minutes = new Regex(@"(\d{2})(?=:)");
				Regex seconds = new Regex(@"(?<=:)(\d{2})");
				MatchCollection min = minutes.Matches(str);
				MatchCollection sec = seconds.Matches(str);
				foreach (Match m in min)
				{
					digitMin = int.Parse(m.Value);
					Console.WriteLine("Minutes: " + digitMin);
					sum += digitMin*60;
				}
				foreach (Match s in sec)
				{
					digitSec = int.Parse(s.Value);
					Console.WriteLine("Seconds: " + digitSec);
					sum += digitSec;
				}
				Console.WriteLine();
				for (int i = 0; i < trackList.Length; i++) 
				{
					if (duration[minDuration] > duration[i]) 
					{
						minDuration = i;
					}
	
					if (duration[maxDuration] < duration[i]) 
					{
						maxDuration = i;
					}
				}
			}
			Console.WriteLine();
			Console.WriteLine("Summary time is " + sum + " sec");
			Console.WriteLine("The shortest song: " + trackList[minDuration]);
			Console.WriteLine("The longest song: " + trackList[maxDuration]);
			Console.ReadKey();
		}
    }
}
