using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Do_An_HDT_1988308.Entities;

namespace Do_An_HDT_1988308.DAL
{
    public class LT_USER
    {
        public List<USER> DocDanhSachUser()
        {
            string filePath = HttpContext.Current.Server.MapPath("~") + "Data\\User.txt";
            StreamReader reader = new StreamReader(filePath);
            var ds = new List<USER>();
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] M = line.Split(',');
                var user = new USER(int.Parse(M[0]), M[1], M[2]);
                ds.Add(user);
            }
            reader.Close();
            return ds;
        }
        
        public void LuuUser(USER user)
        {
            var ds = DocDanhSachUser();
            ds.Add(user);
            LuuDanhSachUser(ds);
        }
        public void LuuDanhSachUser(List<USER> ds)
        {
            string filePath = HttpContext.Current.Server.MapPath("~") + "Data\\User.txt";
            StreamWriter writer = new StreamWriter(filePath);
            for(int i = 0;i<ds.Count;i++)
            {
                writer.WriteLine($"{ds[i].ID},{ds[i].UserName},{ds[i].PassWord}");
            }
            writer.Close();
        }
    }
}