using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSTaiKhoan
    {
        DALTaiKhoan dalTaiKhoan = new DALTaiKhoan();
        public List<TAIKHOAN> GetAllTaiKhoan()
        {
            return dalTaiKhoan.GetAllTaiKhoan();
        }
        public string GetNameById(int id)
        {
         List<TAIKHOAN>  ds = dalTaiKhoan.GetAllTaiKhoan();
            foreach (var item in ds)
            {
                if (item.MATK == id)
                {
                    return item.HOTEN;
                }
            }
            return null;
        }
        public string GetLoaiTKById(int id)
        {
            List<TAIKHOAN> ds = dalTaiKhoan.GetAllTaiKhoan();
            foreach (var item in ds)
            {
                if (item.MATK == id)
                {
                    return item.MALOAITK;
                }
            }
            return null;
        }
    }
}
