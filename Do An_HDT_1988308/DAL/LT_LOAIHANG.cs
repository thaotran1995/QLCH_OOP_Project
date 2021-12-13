using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Do_An_HDT_1988308.Entities;

namespace Do_An_HDT_1988308.DAL
{
    public class LT_LOAIHANG
    {
        public List<LOAI_HANG> DocDanhSachLoaiHang()
        {
            string filePath = HttpContext.Current.Server.MapPath("~") + "Data\\LoaiHang.txt";
            StreamReader reader = new StreamReader(filePath);
            var dsLoaiHang = new List<LOAI_HANG>();
            
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] M = line.Split(',');
                var lh = new LOAI_HANG(int.Parse(M[0]), M[1],M[2]);
                dsLoaiHang.Add(lh);
            }
            reader.Close();
            return dsLoaiHang;
        }
        public void LuuLoaiHang(LOAI_HANG lh)
        {
            var ds = DocDanhSachLoaiHang();
            ds.Add(lh);
            LuuDanhSachLoaiHang(ds);
        }
        public void LuuDanhSachLoaiHang(List<LOAI_HANG> ds)
        {
            string filePath = HttpContext.Current.Server.MapPath("~") + "Data\\LoaiHang.txt";
            StreamWriter writer = new StreamWriter(filePath);
     
            for(int i =0; i<ds.Count; i++)
            {
                writer.WriteLine($"{ds[i].ID},{ds[i].MaLoaiHang},{ds[i].TenLoaiHang}");
            }
            writer.Close();
        }
    }
    
}