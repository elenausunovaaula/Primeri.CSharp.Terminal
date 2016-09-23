using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//for (int i = 5; i > 0; i++) 		// нараства с едно -> 1,2,3,4,5
			//for (int i = 5; i > 0; i--)			//намалява с едно -> 5,4,3,2,1
			//for (int i = 0; i < 5; i++)			// 1,2,3,4,5
			for (int i = 0; i <= 5; i+=2)			//през едно ->0,2,4
				
				Console.WriteLine( i.ToString () );
		}
	}
}
