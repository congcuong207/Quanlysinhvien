﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlysinhvien.Entities
{
    class Monhoc
    {
        string maMH;
        string tenMH;
        string soTin;
        string maGV;

        public Monhoc()
        {
        }

        public Monhoc(string maMH, string tenMH, string soTin, string maGV)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.soTin = soTin;
            this.maGV = maGV;
        }

        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public string SoTin { get => soTin; set => soTin = value; }
        public string MaGV { get => maGV; set => maGV = value; }
    }
}
