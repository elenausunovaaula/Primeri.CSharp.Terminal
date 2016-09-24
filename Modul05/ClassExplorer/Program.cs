﻿using System;

namespace ClassExplorer
{

	public class person
	{
		public string simpleString = "тестова променлива от клас";
		public string user = "";

		private string hiddenString = "";

		public person(string _ini)
		{
			getUser(_ini);
			setWelcomeText();
		}


		private void getUser(string _ini)
		{
			if (_ini == "password1") hiddenString = "Потребител1";
			if (_ini == "password2") hiddenString = "Потребител2";

			user = hiddenString;
		}

		private void setWelcomeText()
		{
			if (hiddenString.Length > 0)
				simpleString = "Добре дошли отново, " + user + "!";
			else
				simpleString = "Вие нямате достъп до тази програма";
		}

		public string getWelcomeMessage()
		{
			return simpleString;

		}

	}


		class MainClass
		{
			public static void Main(string[] args)
			{
				Console.Write("Парола: "); string _user = Console.ReadLine();


				//Дефиниране на клас
				person _person = new person(_user);


				//Достъпване на клас
				Console.WriteLine(_person.getWelcomeMessage() );
			}
		}
}
