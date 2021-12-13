using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Do_An_HDT_1988308.DAL;
using Do_An_HDT_1988308.Entities;

namespace Do_An_HDT_1988308.Service
{
    public class XL_HOADON_BAN
    {
        public List<HOADON_BAN> TimKiemHoaDonBan(string keyword)
        {
            var lt = new LT_HOADON_BAN();
            var ds = lt.DocDanhSachHoaDonBan();
            var kq = new List<HOADON_BAN>();
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
        public void ThemHoaDonBan(string tenHD, string tenKH, string tenMH, string maLH, int sl, int gia)
        {
            var lt = new LT_HOADON_BAN();
            var ds = lt.DocDanhSachHoaDonBan();
            int maHD = 0;
            for(int i = 0;i<ds.Count;i++)
            {
                if(maHD < ds[i].MaHD)
                {
                    maHD = ds[i].MaHD;
                }    
            }
            maHD++;
            var hdb = new HOADON_BAN(maHD, tenHD, tenKH, tenMH, maLH, sl, gia);
            lt.LuuHoaDonBan(hdb);
        }
        public void SuaHoaDonBan(HOADON_BAN hdb)
        {
            var lt = new LT_HOADON_BAN();
            var ds = lt.DocDanhSachHoaDonBan();
           
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaHD == hdb.MaHD)
                {
                    ds[i] = hdb;
                }
            }
            lt.LuuDanhSachHoaDonBan(ds);
        }
        public HOADON_BAN DocHoaDonBan(int maHD)
        {
            var lt = new LT_HOADON_BAN();
            var ds = lt.DocDanhSachHoaDonBan();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaHD == maHD)
                {
                    return ds[i];
                }
            }
            return null;
        }
        public void XoaHoaDonBan(int ma)
        {
            var lt = new LT_HOADON_BAN();
            var ds = lt.DocDanhSachHoaDonBan();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaHD == ma)
                {
                    ds.Remove(ds[i]);
                }
            }
            lt.LuuDanhSachHoaDonBan(ds);
        }
    }
}