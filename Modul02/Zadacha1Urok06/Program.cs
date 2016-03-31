using System;

namespace ZadOneUrokSix
	{
		class MainClass
		{
			
		//Модул 02, Урок 06
		//Задачa1: Деклариране две променливи от тип string и им присвоете стойности "Hello" и "World".
		//Задача2:Декларирайте променлива от тип object и й присвоете стойността на конкатенацията на двете променливи от тип string
		//(не изпускайте интервала по средата).
			
			// Решение на Задача 1 и Задача 2

			string first = "Hello";  
			string second = "World";	
			object greating = (first + " " + second);
			Console.WriteLine ("\nИзписва променлива от тип object: " + greating + "\n");
				

		//Задача3:Декларирайте трета променлива от тип string и я инициализирайте със стойността на променливата от тип object.
			  //( Hint: Трябва да използвате type casting.)
				
		//Решение на Задача3
	
			string third = greating.ToString();
			Console.WriteLine ("\nИзписва string, който идва от object:\n" + third + "\n");
			
		//Други варианти:
			string third1 = greating as string;
			Console.WriteLine ("\nИзписва string, който идва от object 1-ви вариант: \n" + third1 + "\n");

			string third2 = (string)greating;
			Console.WriteLine ("\nИзписва string, който идва от object 3-ти вариант: \n" + third2 + "\n");


		//Задача4:Да се въведат от командния ред 1 число или цифра и 1 дума/стринг. След това да изведе дължината на получения стринг при конкатенация,
		//тоест броя на символите в новополучения стринг при конкатенация.
				//(Hint: Трябва да преобразувате int към String и след това да конкатениратe.)

		//Решение на Задача 4
			int aNumber = 0;
			string aWord = "";
					Console.Write ("Моля въведете желаното количество: ");
					aNumber = Convert.ToInt32(Console.ReadLine ());
					Console.Write ("Моля въведете желания продукт: ");
				aWord = (Console.ReadLine ());
		//string custOrder = aNumber + " " + aWord; -> работи и така. явно не схващам нещо или не съм използвала очакваната функция...
			string custOrder = aNumber.ToString() + " " + aWord;
			Console.WriteLine ("\nВие поръчахте: "  + custOrder);
			Console.WriteLine ("\nБрой символи в поръчката: "  + custOrder.Length);

		}
	}
}
