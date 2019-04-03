using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternDB.Models;

namespace DesignPatternDB.Presenters
{
	public class Presenter
	{
		protected static DesignPatternDBEntities entities;
		protected Presenter()
		{
			SetEntities();
		}
		private static void SetEntities()
		{
			if (entities == null)
				entities = new DesignPatternDBEntities();

		}
	}
}
