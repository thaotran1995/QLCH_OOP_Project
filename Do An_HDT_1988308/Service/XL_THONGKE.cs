using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using Do_An_HDT_1988308.Entities;
using Do_An_HDT_1988308.DAL;


namespace Do_An_HDT_1988308.Service
{
    public class XL_THONGKE
    {
        public List<MAT_HANG> KiemTraTonKho(LOAI_HANG lh)
        {
            var lt = new LT_MATHANG();
            var dsMH = lt.DocDanhSachMatHang();
            List<MAT_HANG> dsKQ = new List<MAT_HANG>();
            foreach(var mh in dsMH)
            {
                if(mh.MaLoaiHang == lh.MaLoaiHang)
                {
                    dsKQ.Add(mh);
                }   
            }

            return dsKQ;
        }
        public List<MAT_HANG> KiemTraHetHan(string s)
        {
            // chuỗi s = "dd/MM/yyyy"
            DateTime ngaykt = DateTime.ParseExact(s, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            var lt = new LT_MATHANG();
            var dsMH = lt.DocDanhSachMatHang();
            var dsKQ = new List<MAT_HANG>();
            for (int i = 0; i < dsMH.Count; i++)
            {
                TimeSpan kc = dsMH[i].HanSD - ngaykt;
                if (kc.Days <=0)
                {
                    dsKQ.Add(dsMH[i]);
                }
            }
            return dsKQ;
        }
    }
    
}