using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlysinhvien.Entities
{
    class Sinhvien
    {
        string maSV;
        string tenSV;
        string gioiTinh;
        DateTime ngaySinh;
        string maLop;
        string queQuan;
        string soDT;
        public Sinhvien()
        {

        }
        public Sinhvien(string maSV, string tenSV, string gioiTinh, DateTime ngaySinh, string maLop, string queQuan, string soDT)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.maLop = maLop;
            this.queQuan = queQuan;
            this.soDT = soDT;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string TenSV { get => tenSV; set => tenSV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string SoDT { get => soDT; set => soDT = value; }
    }
}
