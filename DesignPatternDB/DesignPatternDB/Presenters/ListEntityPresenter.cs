using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using DesignPatternDB.Views;

namespace DesignPatternDB.Presenters
{
	public abstract class ListEntityPresenter<T> : Presenter where T : class
	{
		protected DbSet<T> dbSet;
		protected BindingSource bindingSource = new BindingSource();
		protected IViewListEntity<T> viewList;
		protected IViewEntity<T> view;

		public void SetView(IViewEntity<T> view)
		{
			this.view = view;
		}
		public void SetViewList(IViewListEntity<T> viewList)
		{
			this.viewList = viewList;
		}
		protected virtual void SetBindingSource()
		{
			bindingSource.DataSource = dbSet.ToList();
		}
		public void ViewList()
		{
			if (viewList != null)
			{ 
				viewList.ViewList(bindingSource);
				return;
			}
			if (view != null)
				view.ViewList(bindingSource);
		}

	}
}
