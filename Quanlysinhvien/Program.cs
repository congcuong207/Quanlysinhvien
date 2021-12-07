using Quanlysinhvien.Business;
using Quanlysinhvien.Entities;
using Quanlysinhvien.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlysinhvien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding= Encoding.Unicode;
            Console.OutputEncoding= Encoding.Unicode;
           new Run().Start();
        }
    }
}
