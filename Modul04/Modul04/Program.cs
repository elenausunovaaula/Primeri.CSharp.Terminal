using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Дефиниране на стойности

			string[,] _table = {
				{ "Иван",       "Георгиев",     "19" },
				{ "Васил",      "Иванов",       "23" },
				{ "Милен",      "Георгиев",     "58" },
				{ "Цветан",     "Бориславов",   "14" },
				{ "Гергана",    "Василева",     "25" },
				{ "Ивана",      "Христева",     "21" }
			};

			//Антетка на таблицата
			Console.WriteLine("Име".PadRight (12) + "Фамилия".PadRight(12) + "Година".PadRight(12));
			Console.WriteLine("===========================================");

			//Тяло на таблицата



			//Пример с for
			//for (int i = 0; i < _table.Length /3; i++)		//общ брой 18 -> (int i = 0; i < _table.Length; i++) Console.WriteLine ();, _table.Length /3 разделя на 3; обхожда броя на редовете
			//{
			//	for (int j = 0; j < 3 ; j++)				//обхожда броя на колоните
			//	{
			//		Console.Write(_table[i, j].PadRight(12));				              
			//	}

			//	Console.WriteLine();
			//}


			//Пример с while
			//int i = 0;

			//while (i < _table.Length / 3)
			//{
			//	Console.WriteLine(
			//		_table[i, 0].PadRight(12) +
			//		_table[i, 1].PadRight(12) +
			//		_table[i, 2].PadRight(12)
			//		   );

			//	i++;
			//}


			//Пример с do ... while

			int i = 0;
			do
			{

				//код

				Console.WriteLine(
						_table[i, 0].PadRight(12) +
						_table[i, 1].PadRight(12) +
						_table[i, 2].PadRight(12)
						   );
				i++;

			} while (i < _table.Length / 3);


		}
	}
}
