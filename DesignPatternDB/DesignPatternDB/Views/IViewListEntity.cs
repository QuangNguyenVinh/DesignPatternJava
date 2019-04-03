using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternDB.Views
{
	public interface IViewListEntity<T> where T : class
	{
		void ViewList(BindingSource bindingSource);
	}
}
