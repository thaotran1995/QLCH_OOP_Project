using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Do_An_HDT_1988308.DAL;
using Do_An_HDT_1988308.Entities;

namespace Do_An_HDT_1988308.Service
{
    public class XL_USER
    {
        public bool KiemTraLogin(string name, string pass)
        {
            
            var lt = new LT_USER();
            var user = TimKiem(name);
            if(user.PassWord == pass)
            {
                return true;
            }
            return false;
            
        }
        public void DangKy(string name, string pass)
        {
            var lt = new LT_USER();
            var ds = lt.DocDanhSachUser();
            int id = 0;
            for(int i =0;i<ds.Count;i++)
            {
                if(id<ds[i].ID)
                {
                    id = ds[i].ID;
                }
            }
            id++;
            var user = new USER(id, name, pass);
            lt.LuuUser(user);
            
        }
        public USER TimKiem(string username)
        {
            var lt = new LT_USER();
            var ds = lt.DocDanhSachUser();
            foreach (var user in ds)
            {
                if (user.UserName == username)
                {
                    return user;
                }
            }
            return new USER();
        }
    }
}