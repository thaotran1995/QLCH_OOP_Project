using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.IO;
using Do_An_HDT_1988308.Entities;


namespace Do_An_HDT_1988308.DAL
{
    public class LT_MATHANG
    {
        public List<MAT_HANG> DocDanhSachMatHang()
        {
            string filePath = HttpContext.Current.Server.MapPath("~") + "Data\\MatHang.txt";
            List<MAT_HANG> dsMatHang = new List<MAT_HANG>();
            StreamReader reader = new StreamReader(filePath);
   
            
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] M = line.Split(',');
                var mh = new MAT_HANG();
                mh.MaMH = int.Parse(M[0]);
                mh.TenMH = M[1];
                mh.NamSX = DateTime.ParseExact(M[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                mh.TenCongTy = M[3];
                mh.HanSD = DateTime.ParseExact(M[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                mh.MaLoaiHang = M[5];

                dsMatHang.Add(mh);
            }
            reader.Close();
            return dsMatHang;
        }
        public void LuuDanhSachMatHang(List<MAT_HANG> ds)
        {
            string filePath = HttpContext.Current.Server.MapPath("~") + "Data\\MatHang.txt";
            StreamWriter writer = new StreamWriter(filePath);
            foreach(var mh in ds )
            {
                writer.WriteLine($"{mh.MaMH},{mh.TenMH},{mh.NamSX.ToString("dd/MM/yyyy")},{mh.TenCongTy},{mh.HanSD.ToString("dd/MM/yyyy")},{mh.MaLoaiHang}");
            }
            writer.Close();
        }
        public void LuuMatHang(MAT_HANG mh)
        {
            var ds = DocDanhSachMatHang();
            ds.Add(mh);
            LuuDanhSachMatHang(ds);
        }
       
    }
}