using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDB.Views
{
	public interface IViewEntity<T>: IViewListEntity<T> where T : class
	{
		T AddNew();
		T Update();
		T Delete();
		void ViewEntity(T entity);
	}
}
