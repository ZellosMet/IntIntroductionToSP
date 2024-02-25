using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
	internal class Program
	{
		static bool finish = false;
		static bool suspend_plus = false;
		static bool suspend_minus = false;
		static void Main(string[] args)
		{
			//Plus();
			//Minus();
			Thread plus_thread = new Thread(Plus);
			Thread minus_thread = new Thread(Minus);
			Console.WriteLine(Thread.CurrentThread.GetHashCode());
			Console.WriteLine("Press any key to stop");
			plus_thread.Start();
			minus_thread.Start();
			ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.Escape: finish = true; break;
					case ConsoleKey.OemPlus: plus_thread.Suspend(); break;
				}
			} while (key != ConsoleKey.Escape);
			
		}
		static void Plus()
		{
			while (!finish)
			{
				Console.Write($"+ {Thread.CurrentThread.GetHashCode()}\t");
				Thread.Sleep(500);
			}
		}
		static void Minus()
		{
			while (!finish)
			{
				Console.Write($"- {Thread.CurrentThread.GetHashCode()}\t");
				Thread.Sleep(500);
			}
		}
	}
}
