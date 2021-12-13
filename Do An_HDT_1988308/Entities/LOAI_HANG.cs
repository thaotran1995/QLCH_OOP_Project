using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace Do_An_HDT_1988308.Entities
{
    public class LOAI_HANG
    {
        public int ID { get; set; }
        public string MaLoaiHang { get; set; }
        public string TenLoaiHang { get; set; }
      

        public LOAI_HANG()
        {

        }
        public LOAI_HANG(int id,  string maLH,string tenLH)
        {
            this.ID = id;
            this.MaLoaiHang = maLH; 
            this.TenLoaiHang = tenLH;
        }
        

    }
}