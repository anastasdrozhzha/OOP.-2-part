using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Электронная_библиотека
{
    static class Data
    {
        public static string Value { get; set; }
    }
    static class Bookname
    {
        public static string Value { get; set; }
    }
    static class Enum
    {
        public static string Value { get; set; }
    }
    static class inf
    {
        public static string Value { get; set; }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
       
    }
}
