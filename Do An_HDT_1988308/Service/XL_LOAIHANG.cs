using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Do_An_HDT_1988308.DAL;
using Do_An_HDT_1988308.Entities;

namespace Do_An_HDT_1988308.Service
{
    public class XL_LOAIHANG
    {
        public List<LOAI_HANG> TimKiemLoaiHang(string keyword)
        {
            var lt = new LT_LOAIHANG();
            var dsLoaiHang = lt.DocDanhSachLoaiHang();
            var kq = new List<LOAI_HANG>();
            if(string.IsNullOrEmpty(keyword))
            {
                return dsLoaiHang;
            }
            else
            {
                for(int i=0;i<dsLoaiHang.Count;i++)
                {
                    if(dsLoaiHang[i].TenLoaiHang.Contains(keyword))
                    {
                        kq.Add(dsLoaiHang[i]);
                    }    
                }
                return kq;
            }  
            
        }
        public void ThemLoaiHang(string ma, string ten)
        {
            var lt = new LT_LOAIHANG();
            var ds = lt.DocDanhSachLoaiHang();
            int id = 0;
            for(int i = 0;i<ds.Count;i++)
            {
                if(id < ds[i].ID)
                {
                    id = ds[i].ID;
                }    
            }
            id++;
            var lh = new LOAI_HANG(id,ma,ten);
            lt.LuuLoaiHang(lh);
        }
        public void SuaLoaiHang(LOAI_HANG lh)
        {
            var lt = new LT_LOAIHANG();
            var dsLoaiHang = lt.DocDanhSachLoaiHang();
           
            for (int i = 0; i < dsLoaiHang.Count; i++)
            {
                if (dsLoaiHang[i].ID == lh.ID)
                {
                    dsLoaiHang[i] = lh;
                }
            }
            lt.LuuDanhSachLoaiHang(dsLoaiHang);
        }
        public LOAI_HANG DocLoaiHang(int  ma)
        {
            var lt = new LT_LOAIHANG();
            var dsLoaiHang = lt.DocDanhSachLoaiHang();
            for (int i = 0; i < dsLoaiHang.Count; i++)
            {
                if (dsLoaiHang[i].ID == ma)
                {
                    return dsLoaiHang[i];
                }
            }
            return null;
        }
        public void XoaLoaiHang(int id)
        {
            var lt = new LT_LOAIHANG();
            var dsLoaiHang = lt.DocDanhSachLoaiHang();
            for (int i = 0; i < dsLoaiHang.Count; i++)
            {
                if (dsLoaiHang[i].ID == id)
                {
                    dsLoaiHang.Remove(dsLoaiHang[i]);
                }
            }
            lt.LuuDanhSachLoaiHang(dsLoaiHang);
        }
    }
}