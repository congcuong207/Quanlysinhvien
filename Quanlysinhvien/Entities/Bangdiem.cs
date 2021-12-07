using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlysinhvien.Entities
{
    class Bangdiem
    {
        string maSV;
        string maMH;
        string tenSV;
        double diemQT;
        double diemKTHP;

        public Bangdiem()
        {
        }

        public Bangdiem(string maSV, string maMH, string tenSV, double diemQT, double diemKTHP)
        {
            this.MaSV = maSV;
            this.MaMH = maMH;
            this.TenSV = tenSV;
            this.DiemQT = diemQT;
            this.DiemKTHP = diemKTHP;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string MaMH { get => maMH; set => maMH = value; }
        public string TenSV { get => tenSV; set => tenSV = value; }
        public double DiemQT { get => diemQT; set => diemQT = value; }
        public double DiemKTHP { get => diemKTHP; set => diemKTHP = value; }
    }
}
