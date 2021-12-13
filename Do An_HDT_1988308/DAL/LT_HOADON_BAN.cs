using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Do_An_HDT_1988308.Entities;

namespace Do_An_HDT_1988308.DAL
{
    public class LT_HOADON_BAN
    {
        public List<HOADON_BAN> DocDanhSachHoaDonBan()
        {
            string filePath = HttpContext.Current.Server.MapPath("~") + "Data\\HoaDonBan.txt";
            StreamReader reader = new StreamReader(filePath);
            var dsHoaDonBan = new List<HOADON_BAN>();
            
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] M = line.Split(',');
                var hdb = new HOADON_BAN(int.Parse(M[0]),M[1],M[2],M[3],M[4],int.Parse(M[5]),int.Parse(M[6]));
                dsHoaDonBan.Add(hdb);
            }
            reader.Close();
            return dsHoaDonBan;
        }
        public void LuuHoaDonBan(HOADON_BAN hdb)
        {
            var ds = DocDanhSachHoaDonBan();
            ds.Add(hdb);
            LuuDanhSachHoaDonBan(ds);
        }
        public void LuuDanhSachHoaDonBan(List<HOADON_BAN> ds)
        {
            string filePath = HttpContext.Current.Server.MapPath("~") + "Data\\HoaDonBan.txt";
            StreamWriter writer = new StreamWriter(filePath);
     
            for(int i =0; i<ds.Count; i++)
            {
                writer.WriteLine($"{ds[i].MaHD},{ds[i].TenHD},{ds[i].TenKhachHang},{ds[i].TenMH},{ds[i].MaLH},{ds[i].SoLuong},{ds[i].DonGia}");
            }
            writer.Close();
        }
    }
    
}