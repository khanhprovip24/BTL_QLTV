using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DALTaiKhoan 
    {
        private static DALTaiKhoan instance;
        //Đảm bảo rằng chỉ có một thể hiện duy nhất của lớp DALNguoiDung tồn tại trong suốt vòng đời của ứng dụng.
        public static DALTaiKhoan Instance
        {
            get
            {
                if (instance == null) instance = new DALTaiKhoan();
                return instance;
            }
            set => instance = value;
        }
        public List<TAIKHOAN> GetAllTaiKhoan()
        {
            return QUANLYTHUVIENEntities2.Instance.TAIKHOANs.ToList();
        }  
    }
}
