using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace Do_An_HDT_1988308.Entities
{
    public class HOADON_BAN
    {
        public int MaHD { get; set; }
        public string TenHD { get; set; }
        public string TenKhachHang { get; set; }
        public string TenMH { get; set; }
        public string MaLH { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }


        public HOADON_BAN()
        {

        }
        public HOADON_BAN(int maHD,  string tenHD ,string tenKH, string tenMH,string maLH, int sl, int dg)
        {
            this.MaHD = maHD;
            this.TenHD = tenHD; 
            this.TenKhachHang = tenKH;
            this.TenMH = tenMH;
            this.MaLH = maLH;
            this.SoLuong = sl;
            this.DonGia = dg;
        }
        

    }
}