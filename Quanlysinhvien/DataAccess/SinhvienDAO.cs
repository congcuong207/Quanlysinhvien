using Quanlysinhvien.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlysinhvien.DataAccess
{
    class SinhvienDAO
    {
        public void GhiThongTin(List<Sinhvien> sinhviens)
        {
            //string maSV, string tenSV, string gioiTinh, DateTime ngaySinh, string maLop, string queQuan, string soDT
            StreamWriter writer = new StreamWriter("Sinhvien.txt");
            foreach (Sinhvien sv in sinhviens)
            {
                writer.WriteLine(sv.MaSV + "#" + sv.TenSV + "#" + sv.GioiTinh + "#" + sv.NgaySinh.ToString("yyyy/MM/dd") + "#" + sv.MaLop+"#"+sv.QueQuan+"#"+sv.SoDT);
            }
            writer.Close();
        }
        public List<Sinhvien> LayDS()
        {
            List<Sinhvien> sinhviens = new List<Sinhvien>();
            StreamReader sr = new StreamReader("Sinhvien.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                string[] tmp = s.Split('#');
                sinhviens.Add(new Sinhvien(tmp[0], tmp[1], tmp[2], DateTime.Parse(tmp[3]), tmp[4], tmp[5], tmp[6]));

            }
            sr.Close();
            return sinhviens;

        }
    }
}
