using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternDB.Models;
namespace DesignPatternDB.Views
{
	public interface IViewList
	{
		void ViewListEntity(List<KHACHHANG> entities);
		void ViewEntity(KHACHHANG entity);
		KHACHHANG AddNew();
		
	}
}
