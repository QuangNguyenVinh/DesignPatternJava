using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternDB.Models;

namespace DesignPatternDB.Presenters
{
	public class KhachHangPresenter : EntityPresenter<KHACHHANG>
	{
		public KhachHangPresenter():base()
		{
			dbSet = entities.KHACHHANGs;
			SetBindingSource();
		}

		protected override KHACHHANG FindEntity(KHACHHANG entity)
		{
			//throw new NotImplementedException();
			KHACHHANG kh;
			kh = dbSet.FirstOrDefault(t => t.KhachHangID == entity.KhachHangID);
			return kh;
		}

		protected override void SetNewInfo(KHACHHANG entityToUpdate, KHACHHANG entity)
		{
			//throw new NotImplementedException();
			entityToUpdate.TenKH = entity.TenKH;
			entityToUpdate.SoDT = entity.SoDT;
			entityToUpdate.DiaChi = entity.DiaChi;
		}
	}
}
