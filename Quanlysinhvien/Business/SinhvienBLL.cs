using Quanlysinhvien.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlysinhvien.Business
{
    class SinhvienBLL
    {
        public void ThemSinhVien(ref List<Sinhvien> sinhviens)
        {
            Sinhvien sv = new Sinhvien();
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║        Nhập thông tin Sinh viên                      ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập mã SV:                                     ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập tên SV:                                    ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập giới tính:                                 ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập ngày sinh:                   (yyyy/MM/dd)  ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập mã lớp:                                    ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập quê quán:                                  ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập số ĐT:                                     ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
            do
            {
                bool kt = true;
                Console.SetCursorPosition(35, 3);
                sv.MaSV = Console.ReadLine();
                foreach (Sinhvien item in sinhviens)
                {
                    if (item.MaSV.ToUpper().Equals(sv.MaSV.ToUpper()))
                    {
                        kt = false;
                    }
                }
                if (sv.MaSV != ""&&kt)
                {
                    break;
                }
            }while(true);
            Console.SetCursorPosition(36, 5);
             sv.TenSV = Console.ReadLine();
            Console.SetCursorPosition(40, 7);
             sv.GioiTinh = Console.ReadLine();
            Console.SetCursorPosition(41, 9);
             sv.NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.SetCursorPosition(38, 11);
            sv.MaLop  = Console.ReadLine();
            Console.SetCursorPosition(38, 13);
             sv.QueQuan = Console.ReadLine();
            Console.SetCursorPosition(35, 15);
            sv.SoDT = Console.ReadLine();
            sinhviens.Add(sv);
        }
        public void HienThi(List<Sinhvien> sinhviens)
        {
            Console.Clear();
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║{5,-25}║{6,-15}║", "Mã SV", "Tên SV", "Giới Tính", "Ngày Sinh", "Mã Lớp", "Quê quán","Số ĐT");
            foreach (Sinhvien sv in sinhviens)
            {
                Hien1(sv);
            }
        }
        public void Hientimkiem(Sinhvien sv)
        {//string MaSach,string TenSach,int SoLuongTon,string MaTL,string MaNXB,string MaTG
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║{5,-25}║{6,-15}║", "Mã SV", "Tên SV", "Giới Tính", "Ngày Sinh", "Mã Lớp", "Quê quán", "Số ĐT");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║{5,-25}║{6,-15}║", sv.MaSV, sv.TenSV, sv.GioiTinh, sv.NgaySinh.ToString("yyyy/MM/dd"), sv.MaLop, sv.QueQuan,sv.SoDT);
        }
        public void Hien1(Sinhvien sv)
        {//string MaSach,string TenSach,int SoLuongTon,string MaTL,string MaNXB,string MaTG
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║{5,-25}║{6,-15}║", sv.MaSV, sv.TenSV, sv.GioiTinh, sv.NgaySinh.ToString("yyyy/MM/dd"), sv.MaLop, sv.QueQuan, sv.SoDT);
        }
        public Sinhvien TimKiem(List<Sinhvien> sinhviens, string maSV)
        {
            Sinhvien svtim=new Sinhvien();
            foreach (Sinhvien sv in sinhviens)
            {
                if (maSV.Equals(sv.MaSV))
                {
                    svtim= sv;
                }
            }
            return svtim;
        }
        public void Xoa(ref List<Sinhvien> sinhviens, Sinhvien sv)
        {

            sinhviens.Remove(sv);
        }
        public void Sua(ref List<Sinhvien> sinhviens, string maSV)
        {
            Console.Clear();
            foreach (Sinhvien sv in sinhviens)
            {
                if (maSV.Equals(sv.MaSV))
                {
                    Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║         Sửa thông tin sinh viên                      ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa mã SV:                                      ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa tên SV:                                     ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa giới tính:                                  ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa ngày sinh:                    (yyyy/MM/dd)  ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa mã lớp:                                     ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa quê quán:                                   ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa số ĐT:                                      ║");
                    Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
                    do
                    {
                        bool kt = true;
                        Console.SetCursorPosition(35, 3);
                        string ma = Console.ReadLine();
                        foreach (Sinhvien item in sinhviens)
                        {
                            if (item.MaSV.ToUpper().Equals(ma.ToUpper()))
                            {
                                kt = false;
                            }
                            else if(ma.ToUpper().Equals(sv.MaSV))
                            {
                                kt = true;
                                break;
                            }    
                        }
                        if (sv.MaSV != "" && kt)
                        {
                            sv.MaSV=ma;
                            break;
                        }
                    } while (true);
                    Console.SetCursorPosition(36, 5);
                    sv.TenSV = Console.ReadLine();
                    Console.SetCursorPosition(40, 7);
                    sv.GioiTinh = Console.ReadLine();
                    Console.SetCursorPosition(41, 9);
                    sv.NgaySinh = DateTime.Parse(Console.ReadLine());
                    Console.SetCursorPosition(38, 11);
                    sv.MaLop = Console.ReadLine();
                    Console.SetCursorPosition(38, 13);
                    sv.QueQuan = Console.ReadLine();
                    Console.SetCursorPosition(35, 15);
                    sv.SoDT = Console.ReadLine();

                }
            }
        }
    }
}
