using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_01
{
    public class ToaDo
    {
		private int toaDoX;
		private int toaDoY;
		private string tenToaDo;
		public int getToaDoX()
        {
			return toaDoX;
        } 
		
		public void setToaDoX(int toaDoX)
        {
			this.toaDoX = toaDoX;
        }
		public int getToaDoY()
		{
			return toaDoY;
		}

		public void setToaDoY(int toaDoY)
		{
			this.toaDoY = toaDoY;

		}

		public string getTenToaDo()
		{
			return tenToaDo;
		}

		public void setTenToaDo(string tenToaDo)
		{
			this.tenToaDo = tenToaDo;

		}
		public ToaDo()
        {

        }
		public ToaDo(int toaDoX, int toaDoY, string tenToaDo)
		{
			this.toaDoX = toaDoX;
			this.toaDoY = toaDoY;
			this.tenToaDo = tenToaDo;
		}

		public string toString() 
		{
			return "" + tenToaDo + "(" + toaDoX + ";" + toaDoY + ")";
		}
	}
}
