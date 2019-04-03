using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public class Config
	{


		private static Config instance;

		private Config() { }


		public static Config Instance()
		{
			if (instance == null)
				instance = new Config();
			return instance;
		}

		List<IObserver> listObsever = new List<IObserver>();

		public void Attach(IObserver observer)
		{
			listObsever.Add(observer);
		}
		public void Detach(IObserver observer)
		{
			listObsever.Remove(observer);
		}
		public void Notify(System.Drawing.Color color)
		{
			for(int i = 0; i < listObsever.Count; i++)
			{
				listObsever[i].updateColor(color);
			}


		}

	}
}
