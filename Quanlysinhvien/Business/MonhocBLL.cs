using Quanlysinhvien.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlysinhvien.Business
{
    class MonhocBLL
    {
        public void ThemMonHoc(ref List<Monhoc> monhocs)
        {
            Monhoc mh = new Monhoc();
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║        Nhập thông tin môn học                        ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập mã MH:                                     ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập Tên MH:                                    ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập số Tín:                                    ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập mã GV:                                     ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
            do
            {
                bool kt = true;
                Console.SetCursorPosition(35, 3);
                mh.MaMH = Console.ReadLine();
                foreach (Monhoc item in monhocs)
                {
                    if (item.MaMH.ToUpper().Equals(mh.MaMH.ToUpper()))
                    {
                        kt = false;
                    }
                }
                if (mh.MaMH != "" && kt)
                {
                    break;
                }
            } while (true);
            Console.SetCursorPosition(36, 5);
            mh.TenMH = Console.ReadLine();
            Console.SetCursorPosition(36, 7);
            mh.SoTin = Console.ReadLine();
            Console.SetCursorPosition(36, 9);
            mh.MaGV = Console.ReadLine();
                        monhocs.Add(mh);
        }
        public void HienThi(List<Monhoc> monhocs)
        {
            Console.Clear();
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", "Mã MH", "Tên MH", "Số Tín", "Mã GV");
            foreach (Monhoc mh in monhocs)
            {
                Hien1(mh);
            }
        }
        public void Hientimkiem(Monhoc mh)
        {
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", "Mã MH", "Tên MH", "Số Tín", "Mã GV");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", mh.MaMH, mh.TenMH, mh.SoTin, mh.MaGV);
        }
        public void Hien1(Monhoc mh)
        {
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", mh.MaMH, mh.TenMH, mh.SoTin, mh.MaGV);
        }
        public Monhoc TimKiem(List<Monhoc> monhocs, string maMH)
        {
            Monhoc mhtim = new Monhoc();
            foreach (Monhoc mh in monhocs)
            {
                if (maMH.Equals(mh.MaMH))
                {
                    mhtim = mh;
                }
            }
            return mhtim;
        }
        public void Xoa(ref List<Monhoc> monhocs, Monhoc mh)
        {

            monhocs.Remove(mh);
        }
        public void Sua(ref List<Monhoc> monhocs, string maMH)
        {
            foreach (Monhoc mh in monhocs)
            {
                if (maMH.Equals(mh.MaMH))
                {
                    Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║        Nhập thông tin môn học                        ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa mã MH:                                      ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa Tên MH:                                     ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa số Tín:                                     ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa mã GV:                                      ║");
                    Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
                    do
                    {
                        bool kt = true;
                        Console.SetCursorPosition(35, 3);
                        string ma = Console.ReadLine();
                        foreach (Monhoc item in monhocs)
                        {
                            if (item.MaMH.ToUpper().Equals(ma.ToUpper()))
                            {
                                kt = false;
                            }
                        }
                        if (mh.MaMH != "" && kt)
                        {
                            mh.MaMH = ma;
                            break;
                        }
                    } while (true);
                    Console.SetCursorPosition(36, 5);
                    mh.TenMH = Console.ReadLine();
                    Console.SetCursorPosition(36, 7);
                    mh.SoTin = Console.ReadLine();
                    Console.SetCursorPosition(36, 9);
                    mh.MaGV = Console.ReadLine();
                }
            }
        }
    }
}
