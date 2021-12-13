using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Do_An_HDT_1988308.Entities;
using Do_An_HDT_1988308.DAL;

namespace Do_An_HDT_1988308.Service
{
    public class XL_MATHANG
    {
        public List<MAT_HANG> TimMatHang(string keyword)
        {
            var lt = new LT_MATHANG();
            var dsMatHang = lt.DocDanhSachMatHang();
            if(string.IsNullOrEmpty(keyword))
            {
                return dsMatHang;
            }
            else
            {
                var ketqua = new List<MAT_HANG>();
                for(int i = 0; i<dsMatHang.Count; i++)
                {
                    if(dsMatHang[i].TenMH.Contains(keyword))
                    {
                        ketqua.Add(dsMatHang[i]);
                    }    
                }
                return ketqua;
            }
            
        }
        public void ThemMatHang(string tenMH, DateTime namSX, string tenCongTy, DateTime hanSD, string maLH)
        {
            var lt = new LT_MATHANG();
            var dsMatHang = lt.DocDanhSachMatHang();
            int maMH = 0;
            for (int i = 0; i < dsMatHang.Count; i++)
            {
                if (maMH < dsMatHang[i].MaMH)
                {
                    maMH = dsMatHang[i].MaMH;
                }
            }
            maMH++;

            MAT_HANG mh = new MAT_HANG(maMH, tenMH, namSX, tenCongTy, hanSD, maLH);
            lt.LuuMatHang(mh);
        }
        public MAT_HANG DocMatHang(int maMH)
        {
            var lt = new LT_MATHANG();
            var dsMatHang = lt.DocDanhSachMatHang();
            for (int i = 0; i < dsMatHang.Count; i++)
            {
                if (dsMatHang[i].MaMH == maMH)
                {
                    return dsMatHang[i];
                }
            }
            return null;
        }
        public void SuaMatHang(MAT_HANG mh)
        {
            var lt = new LT_MATHANG();
            var dsMatHang = lt.DocDanhSachMatHang();
            for (int i = 0; i < dsMatHang.Count; i++)
            {
                if (dsMatHang[i].MaMH == mh.MaMH)
                {
                    dsMatHang[i] = mh;
                }
            }
            lt.LuuDanhSachMatHang(dsMatHang);
        }
         public void XoaMatHang(int maMH)
        {
            var lt = new LT_MATHANG();
            var dsMatHang = lt.DocDanhSachMatHang();
            for (int i = 0; i < dsMatHang.Count; i++)
            {
                if (dsMatHang[i].MaMH == maMH)
                {
                    dsMatHang.Remove(dsMatHang[i]);
                }
            }
            lt.LuuDanhSachMatHang(dsMatHang);
        }

    }
}