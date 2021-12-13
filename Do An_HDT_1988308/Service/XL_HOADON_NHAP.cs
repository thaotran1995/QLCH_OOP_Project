using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Do_An_HDT_1988308.DAL;
using Do_An_HDT_1988308.Entities;

namespace Do_An_HDT_1988308.Service
{
    public class XL_HOADON_NHAP
    {
        public List<HOADON_NHAP> TimKiemHoaDonNHap(string keyword)
        {
            var lt = new LT_HOADON_NHAP();
            var ds = lt.DocDanhSachHoaDonNhap();
            var kq = new List<HOADON_NHAP>();
            if(string.IsNullOrEmpty(keyword))
            {
                return ds;
            }
            else
            {
                for(int i=0;i<ds.Count;i++)
                {
                    if(ds[i].TenHD.Contains(keyword))
                    {
                        kq.Add(ds[i]);
                    }    
                }
                return kq;
            }  
            
        }
        public void ThemHoaDonNhap(string tenHD, string tenNCC, string tenMH, string maLH, int sl, int gia)
        {
            var lt = new LT_HOADON_NHAP();
            var ds = lt.DocDanhSachHoaDonNhap();
            int maHD = 0;
            for(int i = 0;i<ds.Count;i++)
            {
                if(maHD < ds[i].MaHD)
                {
                    maHD = ds[i].MaHD;
                }    
            }
            maHD++;
            var hdn = new HOADON_NHAP(maHD,tenHD,tenNCC,tenMH,maLH,sl,gia);
            lt.LuuHoaDonNhap(hdn);
        }
        public void SuaHoaDonNhap(HOADON_NHAP hdn)
        {
            var lt = new LT_HOADON_NHAP();
            var ds = lt.DocDanhSachHoaDonNhap();
           
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaHD == hdn.MaHD)
                {
                    ds[i] = hdn;
                }
            }
            lt.LuuDanhSachHoaDonNhap(ds);
        }
        public HOADON_NHAP DocHoaDonNhap(int  ma)
        {
            var lt = new LT_HOADON_NHAP();
            var ds = lt.DocDanhSachHoaDonNhap();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaHD == ma)
                {
                    return ds[i];
                }
            }
            return null;
        }
        public void XoaHoaDonNhap(int ma)
        {
            var lt = new LT_HOADON_NHAP();
            var ds = lt.DocDanhSachHoaDonNhap();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaHD == ma)
                {
                    ds.Remove(ds[i]);
                }
            }
            lt.LuuDanhSachHoaDonNhap(ds);
        }
    }
}