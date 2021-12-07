using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlysinhvien.View
{
    class Menu
    {
        public int MenuSV()
        {
            int n = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t╔═══════════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t\t\t║          Quản lý Sinh Vien            ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     1. Thêm sinh viên                 ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     2. Hiện tất cả sinh viên          ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     3. Sửa thông tin sinh viên        ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     4. Xóa sinh viên                  ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     5. Tìm sinh viên                  ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     6. Quay lại                       ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     Chọn:                             ║");
                Console.WriteLine("\t\t\t\t\t\t╚═══════════════════════════════════════╝");
                Console.SetCursorPosition(60, 15);
                try
                {
                    n = int.Parse(Console.ReadLine());//nhập n
                }
                catch
                {

                }
            } while (n < 1 || n > 6);//nếu n <1 hoặc lớn hơn 7 thì lặp lại
            return n;
        }
        
        public int MenuGV()
        {
            int n = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t╔═══════════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t\t\t║          Quản lý Giáo Viên            ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     1. Thêm giáo viên                 ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     2. Hiện tất cả giáo viên          ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     3. Sửa thông tin giáo viên        ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     4. Xóa giáo viên                  ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     5. Tìm giáo viên                  ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     6. Quay lại                       ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     Chọn:                             ║");
                Console.WriteLine("\t\t\t\t\t\t╚═══════════════════════════════════════╝");
                Console.SetCursorPosition(60, 15);
                try
                {
                    n = int.Parse(Console.ReadLine());//nhập n
                }
                catch
                {

                }
            } while (n < 1 || n > 6);//nếu n <1 hoặc lớn hơn 7 thì lặp lại
            return n;
        }
        public int MenuMH()
        {
            int n = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t╔═══════════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t\t\t║          Quản lý Môn Học              ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     1. Thêm môn học                   ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     2. Hiện tất cả môn học            ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     3. Sửa thông tin môn học          ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     4. Xóa môn học                    ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     5. Tìm môn học                    ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     6. Quay lại                       ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     Chọn:                             ║");
                Console.WriteLine("\t\t\t\t\t\t╚═══════════════════════════════════════╝");
                Console.SetCursorPosition(60, 15);
                try
                {
                    n = int.Parse(Console.ReadLine());//nhập n
                }
                catch
                {

                }
            } while (n < 1 || n > 6);//nếu n <1 hoặc lớn hơn 7 thì lặp lại
            return n;
        }
        public int MenuBD()
        {
            int n = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t╔═══════════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t\t\t║          Quản lý Bảng Điểm            ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     1. Thêm bảng điểm                 ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     2. Hiện tất cả bảng điểm          ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     3. Sửa thông tin bảng điểm        ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     4. Xóa bảng điểm                  ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     5. Tìm bảng điểm                  ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     6. Quay lại                       ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     Chọn:                             ║");
                Console.WriteLine("\t\t\t\t\t\t╚═══════════════════════════════════════╝");
                Console.SetCursorPosition(60, 15);
                try
                {
                    n = int.Parse(Console.ReadLine());//nhập n
                }
                catch
                {

                }
            } while (n < 1 || n > 6);//nếu n <1 hoặc lớn hơn 7 thì lặp lại
            return n;
        }
    }
}
