using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternDB.Models;
using DesignPatternDB.Views;

namespace DesignPatternDB.Presenters
{
	/* Subject trong mau Observer
	 * 
	 * 
	 */ 
	public class PresenterKhachHang_
	{
		DesignPatternDBEntities entities = new DesignPatternDBEntities();
		IViewList viewList;
		List<KHACHHANG> list = new List<KHACHHANG>();

		public void SetViewList(IViewList viewList)
		{
			this.viewList = viewList;
		}
		public void ViewListEntities()
		{
			list = entities.KHACHHANGs.ToList();
			viewList.ViewListEntity(list);
		}
		public void ViewEntityAt(int index)
		{
			KHACHHANG kh = list[index];
			viewList.ViewEntity(kh);
		}
		public void AddNewEntity()
		{
			KHACHHANG kh = viewList.AddNew();
			if(entities.KHACHHANGs.FirstOrDefault(t => t.KhachHangID == kh.KhachHangID) == null)
			{
				entities.KHACHHANGs.Add(kh);
				entities.SaveChanges();
				ViewListEntities();
			}
		}
	}
}
