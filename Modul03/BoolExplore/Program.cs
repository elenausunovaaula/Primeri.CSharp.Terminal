using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main()
		{
			//bool _b = true;			//true, false
			//Console.WriteLine(_b);


			//bool _test = 5 > 10;        //false
			//Console.WriteLine(_test);

			int[] _i = new int[] { 4, 3, 2 };
			int _ui = Convert.ToInt32(Console.ReadLine());

			//bool _check01 = _ui <= _i.Length;
			//bool _check02 = _ui > 0;

			//bool _exp01 = _check01 && _check02;      // Логическо и "&&"
			//bool _exp02 = _check01 || _check02;		// Логическо или "||"
			//bool _exp03 = !_check01;				// Отрицание "!"

			//Console.WriteLine( "Логическо И: " + _exp01.ToString () );
			//Console.WriteLine( "Логическо ИЛИ: " + _exp02.ToString () );
			//Console.WriteLine("Отрицание на: " + _exp01.ToString() + ": " + _exp03 );

			//Console.WriteLine(_check01);
			//Console.WriteLine(_check02);

			//Console.WriteLine(_i[_ui - 1]);

			//if (_ui > 0 && _ui <= _i.Length)
			//{
			//	Console.WriteLine(_i[_ui - 1]);
			//}
			//else {
			//	Console.WriteLine("Невалиден индекс\n\n\n");
			//}

			if (_ui > 0 && _ui <= _i.Length)
			{
				Console.WriteLine(_i[_ui - 1]);
			}
			else {
				if (_ui > _i.Length)
				{
					Console.WriteLine("Индексът е прекалено голям\n\n\n");
				}
				if (_ui <= 0)
				{
					Console.WriteLine("Индексът е прекалено малък\n\n\n");
				}
			}
		}
	}
}

