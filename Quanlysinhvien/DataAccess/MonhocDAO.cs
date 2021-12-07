using Quanlysinhvien.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlysinhvien.DataAccess
{
    class MonhocDAO
    {
        public void GhiThongTin(List<Monhoc> monhocs)
        {
            //string maMH, string tenMH, string soTin, string maGV
            StreamWriter writer = new StreamWriter("Monhoc.txt");
            foreach (Monhoc mh in monhocs)
            {
                writer.WriteLine(mh.MaMH + "#" + mh.TenMH + "#" + mh.SoTin + "#" + mh.MaGV);
            }
            writer.Close();
        }
        public List<Monhoc> LayDS()
        {
            List<Monhoc> monhocs = new List<Monhoc>();
            StreamReader sr = new StreamReader("Monhoc.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                string[] tmp = s.Split('#');
                monhocs.Add(new Monhoc(tmp[0], tmp[1], tmp[2], tmp[3]));

            }
            sr.Close();
            return monhocs;

        }
    }
}
