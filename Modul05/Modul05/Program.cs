﻿using System;

namespace Modul05
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			//Дефиниции

			string usercommand = "";

			//Потребителски команди
			do
			{
				Console.Write("$ "); usercommand = Console.ReadLine();

				if (usercommand.Contains("cmd01")) cmd01(usercommand);
				if (usercommand.Contains("cmd02")) Console.WriteLine(cmd02(usercommand));

				if (usercommand.Contains("cmd03"))
				{
					double _a = 0;

					if (cmd03(usercommand, out _a))
					{
						Console.WriteLine("a . a = " + _a.ToString());
					}else
					{
						Console.WriteLine("Командата не е въведена коректно");
					}
				}

				if (usercommand.Contains("cmd04"))
				{
					double _t = 5, _c = -2;
					if (cmd04(ref _t))
					{
						Console.WriteLine(_t);
					}
					if (cmd04(ref _c))
					{
						Console.WriteLine(_t);
					}
						       
				}

				if (usercommand.Contains("cmd05"))		//да разберем колко четни числа имаме
				{
					Console.WriteLine("Брой четни числа: " + cmd05(usercommand).Length.ToString());
				}


			} while (usercommand != "exit");

		}

			public static void cmd01(string _input)      //cmd01 5 		---> 5 ^2 = 25
			{
				try
				{
					double _temp = 0;

					if (double.TryParse(_input.Split(' ')[1], out _temp))
					{
						Console.WriteLine("\nРезултат от " + _temp.ToString() + " ^2: " + (_temp * _temp).ToString());
					}

				}
				catch
				{
				}
			}

		public static int cmd02(string _input)      //cmd02 		--> 5*5*5 = 125
		{
			int _temp = 0;

			if (int.TryParse(_input.Split(' ')[1], out _temp))
			{
				_temp = _temp * _temp * _temp;
			}
			return _temp;

			//Да се върнат параметрите
		}

			public static bool cmd03(string _input, out double _i)      //cmd03	45	-->45*45
			{
				try
				{
					string _p = _input.Split(' ')[1];
					double __p = 0;
				if (double.TryParse(_p, out __p))
				{
					_i = __p * __p;

					return true;
				}
				}catch{ 		//error }expected ???
				}
				_i = 0;

				return false;
			}

			public static bool cmd04(ref double _i)
			{
				double _temp = _i;
				_i = _i * _i;

				return (_temp > 0);
			}

			public static string[]  cmd05 ( string  _input )		//ERROR 'MainClass.cmd05(string)':not all code paths return a value
			{
				try
					{
					int _border = 0;
					string _temp = "";

						if (int.TryParse(_input.Split(' ')[1], out _border) )
						{
							for (int i = 0; i < _border; i++)
							{
								if (i % 2 == 0) _temp += i.ToString();
								if (i != _border - 1 && i % 2 == 0) _temp += ",";

							}

							Console.WriteLine(_temp);       //само за проверка

							return _temp.Split(',');

							}
					}catch{
					}
					return new string[1] { "0" };
			}
	}
}

