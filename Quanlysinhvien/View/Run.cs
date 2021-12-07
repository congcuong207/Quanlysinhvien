using Quanlysinhvien.Business;
using Quanlysinhvien.DataAccess;
using Quanlysinhvien.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlysinhvien.View
{
    class Run
    {
        public List<Sinhvien> sinhviens= new List<Sinhvien>();
        public List<Monhoc> monhocs= new List<Monhoc>();
        public List<Giaovien> giaoviens = new List<Giaovien>();
        public List<Bangdiem> bangdiems;
        public int MenuRun()
        {
            int n = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t╔═══════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t\t\t║          CHƯƠNG TRÌNH QUẢN LÝ Sinh Viên           ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     1. Quản lý sinh viên                          ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     2. Quản lý giáo viên                          ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     3. Quản lý môn học                            ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     4. Quản lý bảng điểm                          ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     5. Quay lại                                   ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     Chọn:                                         ║");
                Console.WriteLine("\t\t\t\t\t\t╚═══════════════════════════════════════════════════╝");
                Console.SetCursorPosition(60, 13);
                try
                {
                    n = int.Parse(Console.ReadLine());//nhập n
                }
                catch
                {

                }
            } while (n < 1 || n > 5);//nếu n <1 hoặc lớn hơn 5 thì lặp lại
            return n;
        }
        BangdiemBLL bangdiemBLL;
        GiaovienBLL giaovienBLL;
        MonhocBLL monhocBLL;
        SinhvienBLL sinhvienBLL;
        BangdiemDAO bangdiemDAO;
        GiaovienDAO giaovienDAO;
        MonhocDAO monhocDAO;
        SinhvienDAO sinhvienDAO;

            Menu menu;
        public void Init()
        {

            bangdiemBLL = new BangdiemBLL();
             giaovienBLL = new GiaovienBLL();
             monhocBLL = new MonhocBLL();
             sinhvienBLL = new SinhvienBLL();
             bangdiemDAO = new BangdiemDAO();
             giaovienDAO = new GiaovienDAO();
             monhocDAO = new MonhocDAO();
             sinhvienDAO = new SinhvienDAO();
            sinhviens = sinhvienDAO.LayDS();
            giaoviens = giaovienDAO.LayDS();
            monhocs = monhocDAO.LayDS();
            bangdiems = bangdiemDAO.LayDS();
             menu = new Menu();
        }
        public void Start()
        {
            Init();
            while (true)
            {
                int chon = MenuRun();
                switch (chon)
                {
                    case 1:

                        do
                        {
                            sinhviens = new List<Sinhvien>();
                            sinhviens = sinhvienDAO.LayDS();
                            chon = menu.MenuSV();
                            switch (chon)
                            {
                                case 1:
                                    sinhvienBLL.ThemSinhVien(ref sinhviens);
                                    sinhvienDAO.GhiThongTin(sinhviens);
                                    break;
                                case 2:
                                    sinhvienBLL.HienThi(sinhviens);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Nhập mã SV cần sửa: ");
                                    sinhvienBLL.Sua(ref sinhviens, Console.ReadLine());
                                    sinhvienDAO.GhiThongTin(sinhviens);
                                    break;
                                case 4:
                                    Console.Write("Nhập mã SV cần xóa: ");
                                    sinhvienBLL.Xoa(ref sinhviens, sinhvienBLL.TimKiem(sinhviens, Console.ReadLine()));
                                    sinhvienDAO.GhiThongTin(sinhviens);
                                    break;
                                case 5:
                                    Console.Write("Nhập mã SV cần tìm: ");
                                    sinhvienBLL.Hientimkiem(sinhvienBLL.TimKiem(sinhviens, Console.ReadLine()));
                                    Console.ReadLine();
                                    break;
                            }
                        } while (chon != 6);
                        break;
                    case 2:

                        do
                        {
                            giaoviens = new List<Giaovien>();
                            giaoviens = giaovienDAO.LayDS();
                            chon = menu.MenuGV();
                            switch (chon)
                            {
                                case 1:
                                    giaovienBLL.ThemGiaoVien(ref giaoviens);
                                    giaovienDAO.GhiThongTin(giaoviens);
                                    break;
                                case 2:
                                    giaovienBLL.HienThi(giaoviens);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Nhập mã TB cần sửa: ");
                                    giaovienBLL.Sua(ref giaoviens, Console.ReadLine());
                                    giaovienDAO.GhiThongTin(giaoviens);
                                    break;
                                case 4:
                                    Console.Write("Nhập mã TB cần xóa: ");
                                    giaovienBLL.Xoa(ref giaoviens, giaovienBLL.TimKiem(giaoviens, Console.ReadLine()));
                                    giaovienDAO.GhiThongTin(giaoviens);
                                    break;
                                case 5:
                                    Console.Write("Nhập mã SV cần tìm: ");
                                    giaovienBLL.Hientimkiem(giaovienBLL.TimKiem(giaoviens, Console.ReadLine()));
                                    Console.ReadLine();
                                    break;
                            }
                        } while (chon != 6);
                        break;
                    case 3:

                        do
                        {
                            monhocs = new List<Monhoc>();
                            monhocs = monhocDAO.LayDS();
                            chon = menu.MenuMH();
                            switch (chon)
                            {
                                case 1:
                                    monhocBLL.ThemMonHoc(ref monhocs);
                                    monhocDAO.GhiThongTin(monhocs);
                                    break;
                                case 2:
                                    monhocBLL.HienThi(monhocs);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Nhập mã phòng TH cần sửa: ");
                                    monhocBLL.Sua(ref monhocs, Console.ReadLine());
                                    monhocDAO.GhiThongTin(monhocs);
                                    break;
                                case 4:
                                    Console.Write("Nhập mã phòng TH cần xóa: ");
                                    monhocBLL.Xoa(ref monhocs, monhocBLL.TimKiem(monhocs, Console.ReadLine()));
                                    monhocDAO.GhiThongTin(monhocs);
                                    break;
                                case 5:
                                    Console.Write("Nhập mã phòng TH cần tìm: ");
                                    monhocBLL.Hientimkiem(monhocBLL.TimKiem(monhocs, Console.ReadLine()));
                                    Console.ReadLine();
                                    break;
                            }
                        } while (chon != 6);
                        break;
                    case 4:

                        do
                        {
                            bangdiems = new List<Bangdiem>();
                            bangdiems = bangdiemDAO.LayDS();
                            chon = menu.MenuBD();
                            switch (chon)
                            {
                                case 1:
                                    bangdiemBLL.ThemBangDiem(ref bangdiems,monhocs,sinhviens);
                                    bangdiemDAO.GhiThongTin(bangdiems);
                                    break;
                                case 2:
                                    bangdiemBLL.HienThi(bangdiems);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Nhập mã phòng TH cần trả: ");
                                    bangdiemBLL.Sua(ref bangdiems,monhocs, sinhviens, Console.ReadLine());
                                    bangdiemDAO.GhiThongTin(bangdiems);
                                    break;
                                case 4:
                                    Console.Write("Nhập mã phòng TH cần xóa: ");
                                    bangdiemBLL.Xoa(ref bangdiems, bangdiemBLL.TimKiem(bangdiems, Console.ReadLine()));
                                    bangdiemDAO.GhiThongTin(bangdiems);
                                    break;
                                case 5:
                                    Console.Write("Nhập mã phòng TH cần tìm: ");
                                    bangdiemBLL.Hientimkiem(bangdiemBLL.TimKiem(bangdiems, Console.ReadLine()));
                                    Console.ReadLine();
                                    break;
                            }
                        } while (chon != 6);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }

        }
    }
}
