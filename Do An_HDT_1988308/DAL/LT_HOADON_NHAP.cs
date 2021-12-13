using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Do_An_HDT_1988308.Entities;

namespace Do_An_HDT_1988308.DAL
{
    public class LT_HOADON_NHAP
    {
        public List<HOADON_NHAP> DocDanhSachHoaDonNhap()
        {
            string filePath = HttpContext.Current.Server.MapPath("~") + "Data\\HoaDonNhap.txt";
            StreamReader reader = new StreamReader(filePath);
            var dsHoaDonNhap = new List<HOADON_NHAP>();
            
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] M = line.Split(',');
                var hdn = new HOADON_NHAP(int.Parse(M[0]),M[1],M[2],M[3],M[4],int.Parse(M[5]),int.Parse(M[6]));
                dsHoaDonNhap.Add(hdn);
            }
            reader.Close();
            return dsHoaDonNhap;
        }
        public void LuuHoaDonNhap(HOADON_NHAP hdn)
        {
            var ds = DocDanhSachHoaDonNhap();
            ds.Add(hdn);
            LuuDanhSachHoaDonNhap(ds);
        }
        public void LuuDanhSachHoaDonNhap(List<HOADON_NHAP> ds)
        {
            string filePath = HttpContext.Current.Server.MapPath("~") + "Data\\HoaDonNhap.txt";
            StreamWriter writer = new StreamWriter(filePath);
     
            for(int i =0; i<ds.Count; i++)
            {
                writer.WriteLine($"{ds[i].MaHD},{ds[i].TenHD},{ds[i].TenNhaCC},{ds[i].TenMH},{ds[i].MaLH},{ds[i].SoLuong},{ds[i].DonGia}");
            }
            writer.Close();
        }
    }
    
}