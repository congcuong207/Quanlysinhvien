using Quanlysinhvien.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlysinhvien.DataAccess
{
    class GiaovienDAO
    {
        public void GhiThongTin(List<Giaovien> giaoviens)
        {
            //string maGV, string tenGV, string gioTinh, DateTime namSinh, string soDT
            StreamWriter writer = new StreamWriter("Giaovien.txt");
            foreach (Giaovien gv in giaoviens)
            {
                writer.WriteLine(gv.MaGV + "#" + gv.TenGV + "#" + gv.GioTinh+"#"+gv.NamSinh.ToString("yyyy/MM/dd")+"#"+gv.SoDT);
            }
            writer.Close();
        }
        public List<Giaovien> LayDS()
        {
            List<Giaovien> giaoviens = new List<Giaovien>();
            StreamReader sr = new StreamReader("Giaovien.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                string[] tmp = s.Split('#');
                giaoviens.Add(new Giaovien(tmp[0], tmp[1],tmp[2], DateTime.Parse(tmp[3]), tmp[4]));

            }
            sr.Close();
            return giaoviens;

        }
    }
}
