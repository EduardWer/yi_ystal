using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ia_ystal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CursorPos;
            string path;
            List<DriveInfo> drives = new List<DriveInfo>();
            string[] files;
            Menus menus = new Menus(0,0);
            while (true)
            {
                drives = Explorer.GetDrives();
                menus = new Menus(2, drives.Count + 1);
                CursorPos = menus.Menu();
                path = drives[CursorPos - 2].Name;
                do
                {
                    
                    Explorer.GetFiles(path);

                }
                while (CursorPos != 0);
            }                                                                                                                                                                                                                                                                                                                                                                                       //Сделал Эдуард
            

        }
    }
}
