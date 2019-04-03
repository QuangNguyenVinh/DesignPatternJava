using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDB.Presenters
{
	public abstract class EntityPresenter<T>: ListEntityPresenter<T> where T : class
	{
		protected abstract T FindEntity(T entity);
		protected abstract void SetNewInfo(T entityToUpdate, T entity);
		public void AddNew()
		{
			T entity = view.AddNew();
			T old = FindEntity(entity);
			if(old == null)
			{
				dbSet.Add(entity);
				entities.SaveChanges();
				SetBindingSource();
			}
		}

		public void Update()
		{
			T entity = view.Update();
			T entityToUpdate = FindEntity(entity);
			if(entityToUpdate != null)
			{
				SetNewInfo(entityToUpdate, entity);
				entities.SaveChanges();
				SetBindingSource();
			}
		}

		public void Delete()
		{
			T entity = view.Delete();
			T entityToDelete = FindEntity(entity);
			if(entityToDelete != null)
			{
				dbSet.Remove(entityToDelete);
				entities.SaveChanges();
				SetBindingSource();
			}
		}

		public void ViewEntityAt(int index)
		{
			T entity = (T)bindingSource[index];
			view.ViewEntity(entity);
		}
	}
}
