using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	internal class Engine
	{
		static readonly double MIN_CONSUMPRION = 3;
		static readonly double MAX_CONSUMPRION = 3;
		double consumption;
		double consumption_per_second;
		public bool Started { get; private set; }
		public double Consumption
		{
			get => consumption;
			set 
			{
				if(value< MIN_CONSUMPRION) value = MIN_CONSUMPRION;
				if(value> MAX_CONSUMPRION) value = MAX_CONSUMPRION;
				consumption = value;
				SetConsumptionPerSecond();
			}
		}
		public double ConsumptionPerSecond()
		{ 
			return consumption_per_second;
		}
		void SetConsumptionPerSecond()
		{
			consumption_per_second = consumption / 10000;
		}
		public void Start()
		{ 
			Started = true;
		}
		public void Stop()
		{ 
			Started = false;
		}
		public Engine(double consumption)
		{
			Consumption = consumption;
			Started = false;
		}
		public void Info()
		{
			Console.WriteLine($"Consumption per 100 km: {Consumption}");
			Console.WriteLine($"Consumption per 1 sec: {ConsumptionPerSecond()}");
		}
	}
}
