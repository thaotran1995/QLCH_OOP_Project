using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace Do_An_HDT_1988308.Entities
{
    public class HOADON_NHAP
    {
        public int MaHD { get; set; }
        public string TenHD { get; set; }
        public string TenNhaCC { get; set; }
        public string TenMH { get; set; }
        public string MaLH { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }


        public HOADON_NHAP()
        {

        }
        public HOADON_NHAP(int maHD,  string tenHD ,string tenNCC, string tenMH,string maLH, int sl, int dg)
        {
            this.MaHD = maHD;
            this.TenHD = tenHD; 
            this.TenNhaCC = tenNCC;
            this.TenMH = tenMH;
            this.MaLH = maLH;
            this.SoLuong = sl;
            this.DonGia = dg;
        }
        

    }
}