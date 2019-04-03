using DesignPatternDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDB.Presenters
{
	public class MatHangPresenter : EntityPresenter<MATHANG>
	{
		public MatHangPresenter() : base()
		{
			dbSet = entities.MATHANGs;
			SetBindingSource();
		}
		protected override MATHANG FindEntity(MATHANG entity)
		{
			//throw new NotImplementedException();
			MATHANG mh;
			mh = dbSet.FirstOrDefault(t => t.MaMH == entity.MaMH);
			return mh;
		}

		protected override void SetNewInfo(MATHANG entityToUpdate, MATHANG entity)
		{
			//throw new NotImplementedException();
			entityToUpdate.TenMH = entity.TenMH;
			entityToUpdate.SoLuong = entity.SoLuong;
			entityToUpdate.Gia = entity.Gia;
			entityToUpdate.DVT = entity.DVT;
		}
	}
}
