using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Car
{
	internal class Car
	{
		static readonly int MAX_SPEED_LOW_LIMIT = 30;
		static readonly int MAX_SPEED_HIGH_LIMIT = 400;
		public int MAX_SPEED { get; }
		Engine engine;
		Tank tank;
		bool driver_inside;
		int speed;
		int accelleration;
		public int Speed { get; }
		struct Threads
		{
			public Thread PanelThread { get; set; }
			public Thread EngineIdleThread { get; set; }
			public Thread FreeWheelingThread { get; set; }
		}
		Threads threads;
		public Car(double consumption, int volume, int max_speed = 250, int accelleration = 1)
		{
			engine = new Engine(consumption);
			tank = new Tank(volume);
			threads = new Threads();
			if (max_speed < MAX_SPEED_LOW_LIMIT) max_speed = MAX_SPEED_LOW_LIMIT;
			if (max_speed > MAX_SPEED_HIGH_LIMIT) max_speed = MAX_SPEED_HIGH_LIMIT;
			this.MAX_SPEED = max_speed;
			this.accelleration = accelleration;
			speed = 0;
			driver_inside = false;
		}
		public void GetIn()
		{
			driver_inside = true;
			threads.PanelThread = new Thread(Panel);
			threads.PanelThread.Start();
		}
		public void GetOut()
		{
			driver_inside = false;
			threads.PanelThread.Join();
			Console.Clear();
			Console.WriteLine("Your are out of the car");

		}
		public void Star()
		{ 
			engine.Start();
			threads.EngineIdleThread = new Thread(EngineIdle);
			threads.EngineIdleThread.Start();
		}
		public void Stop()
		{
			engine.Stop();
			if(threads.FreeWheelingThread != null)threads.EngineIdleThread.Join();
		}
		void Accellerate()
		{
			if (engine.Started) speed += accelleration;
			if (speed > MAX_SPEED) speed = MAX_SPEED;
			if (threads.FreeWheelingThread == null)
			{ 
				threads.FreeWheelingThread = new Thread(FreeWheeling);
				threads.FreeWheelingThread.Start();
			}
			//if(threads.FreeWheelingThread != null)Thread.Sleep(1000);
		}
		void SlowDown()
		{ 
			if (speed > 0) speed -= accelleration;
			if (speed < 0) speed = 0;
			if (speed == 0 && threads.FreeWheelingThread != null) threads.FreeWheelingThread.Join();
			//Thread.Sleep(1000);
		}
		public void Control()
		{
			Console.WriteLine("Your car is ready, press Enter to get in");
			ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.F:
						if (!driver_inside)
						{ 
							Console.Write("Введите объём топлива: "); 
							double amount = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
							tank.Fill(amount);
						}
						else Console.WriteLine("Get out of the car");
					break;

					case ConsoleKey.Enter:
						if (driver_inside) GetOut();
						else GetIn();
					break;
					case ConsoleKey.Escape: 
						Stop();
						GetOut();			
					break;
					case ConsoleKey.I:
						if(engine.Started) Stop();
						else Star();
					break;
					case ConsoleKey.W:
						Accellerate();
					break;
					case ConsoleKey.S:
						SlowDown();
					break;
				}
			} while (key != ConsoleKey.Escape);
		}
		void FreeWheeling()
		{
			while (speed-- > 0)
			{
				if (speed < 0) speed = 0;
				Thread.Sleep(1000);
			}
			if (speed < 0) speed = 0;
		}
		void EngineIdle()
		{
			while (engine.Started && tank.GiveFuel(engine.ConsumptionPerSecond()) > 0)			
				Thread.Sleep(1000);			
		}
		void Panel()
		{
			while (driver_inside)
			{
				Console.Clear();
				Console.Write($"Fuel level: {tank.FuelLevel} liters");
				if (tank.FuelLevel < 5)
				{
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("\tLow FUEL");
				}
				Console.ResetColor();
				Console.WriteLine();
				Console.WriteLine($"Engine is: {(engine.Started ? "started" : "stoped")} ");
				Console.WriteLine($"Speed: {speed} km/h");
				Thread.Sleep(200);
			}
		}
		public void Info()
		{
			engine.Info();
			tank.Info();
			Console.WriteLine($"Max speed: {MAX_SPEED} km/h");
		}
	}
}
