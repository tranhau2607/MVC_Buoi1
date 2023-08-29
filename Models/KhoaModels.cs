using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _16_TranThanhHau_Buoi1.Models
{
    public class KhoaModels
    {
        public String TenKhoa { get; set; }
        public int NamThanhLap { get; set; }
        public String Messager { get; set; }

        public KhoaModels()
        {
            TenKhoa = "Khoa Công nghệ thông tin";
            NamThanhLap = 2003;
            Messager = "Chào mừng bạn đến với HUIT";
        }
    }
}