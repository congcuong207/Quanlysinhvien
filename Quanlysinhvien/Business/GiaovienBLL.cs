﻿using Quanlysinhvien.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlysinhvien.Business
{
    class GiaovienBLL
    {
        public void ThemGiaoVien(ref List<Giaovien> giaoviens)
        {
            Giaovien gv = new Giaovien();
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║        Nhập thông tin giáo viên                      ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập mã GV:                                     ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập tên GV:                                    ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập giới tính:                                 ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập ngày sinh:                   (yyyy/MM/dd)  ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập số ĐT:                                     ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
            do
            {
                bool kt = true;
                Console.SetCursorPosition(35, 3);
                gv.MaGV = Console.ReadLine();
                foreach (Giaovien item in giaoviens)
                {
                    if (item.MaGV.ToUpper().Equals(gv.MaGV.ToUpper()))
                    {
                        kt = false;
                    }
                }
                if (gv.MaGV != "" && kt)
                {
                    break;
                }
            } while (true);
            Console.SetCursorPosition(36, 5);
            gv.TenGV = Console.ReadLine();
            Console.SetCursorPosition(40, 7);
            gv.GioTinh = Console.ReadLine();
            Console.SetCursorPosition(41, 9);
            gv.NamSinh = DateTime.Parse(Console.ReadLine());
            Console.SetCursorPosition(35, 11);
            gv.SoDT = Console.ReadLine();
            giaoviens.Add(gv);
        }
        public void HienThi(List<Giaovien> giaoviens)
        {
            Console.Clear();
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║", "Mã GV", "Tên GV", "Giới Tính", "Ngày Sinh", "Số ĐT");
            foreach (Giaovien sv in giaoviens)
            {
                Hien1(sv);
            }
        }
        public void Hientimkiem(Giaovien gv)
        {//string MaSach,string TenSach,int SoLuongTon,string MaTL,string MaNXB,string MaTG
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║", "Mã GV", "Tên GV", "Giới Tính", "Ngày Sinh", "Số ĐT");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║", gv.MaGV, gv.TenGV, gv.GioTinh, gv.NamSinh.ToString("yyyy/MM/dd"), gv.SoDT);
        }
        public void Hien1(Giaovien gv)
        {//string MaSach,string TenSach,int SoLuongTon,string MaTL,string MaNXB,string MaTG
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║", gv.MaGV, gv.TenGV, gv.GioTinh, gv.NamSinh.ToString("yyyy/MM/dd"), gv.SoDT);
        }
        public Giaovien TimKiem(List<Giaovien> giaoviens, string maGV)
        {
            Giaovien gvtim = new Giaovien();
            foreach (Giaovien gv in giaoviens)
            {
                if (maGV.Equals(gv.MaGV))
                {
                    gvtim = gv;
                }
            }
            return gvtim;
        }
        public void Xoa(ref List<Giaovien> giaoviens, Giaovien gv)
        {

            giaoviens.Remove(gv);
        }
        public void Sua(ref List<Giaovien> giaoviens, string maGV)
        {
            foreach (Giaovien gv in giaoviens)
            {
                if (maGV.Equals(gv.MaGV))
                {
                    Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║        Nhập thông tin giáo viên                      ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa mã GV:                                      ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa tên GV:                                     ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa giới tính:                                  ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa ngày sinh:                    (yyyy/MM/dd)  ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa số ĐT:                                      ║");
                    Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
                    do
                    {
                        bool kt = true;
                        Console.SetCursorPosition(35, 3);
                        string ma = Console.ReadLine();
                        foreach (Giaovien item in giaoviens)
                        {
                            if (item.MaGV.ToUpper().Equals(ma.ToUpper()))
                            {
                                kt = false;
                            }
                        }
                        if (gv.MaGV != "" && kt)
                        {
                            gv.MaGV = ma;
                            break;
                        }
                    } while (true);
                    Console.SetCursorPosition(36, 5);
                    gv.TenGV = Console.ReadLine();
                    Console.SetCursorPosition(40, 7);
                    gv.GioTinh = Console.ReadLine();
                    Console.SetCursorPosition(41, 9);
                    gv.NamSinh = DateTime.Parse(Console.ReadLine());
                    Console.SetCursorPosition(35, 11);
                    gv.SoDT = Console.ReadLine();
                }
            }
        }
        }
}
