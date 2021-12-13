using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace Do_An_HDT_1988308.Entities
{
    public class MAT_HANG
    {
        public int MaMH { get; set; }
        public string TenMH { get; set; }
        public DateTime NamSX { get; set; }
        public string TenCongTy { get; set; }
        public DateTime HanSD { get; set; }
        public string MaLoaiHang { get; set; }

        public MAT_HANG()
        {

        }
        public MAT_HANG(int maMH, string TenMH, DateTime NamSX, string tenCT, DateTime HanSD, string MaLH)
        {
            this.MaMH = maMH; 
            this.TenMH = TenMH;
            this.NamSX = NamSX;
            this.TenCongTy = tenCT;
            this.HanSD = HanSD;
            this.MaLoaiHang = MaLH;
        }
        

    }
}