using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VINHHOANG
{
    // class THONG
    //{
    //public char nuocmia;
    //public char n1;

    //public char nuocdua;
    //public char n2;

    //public char suachua;
    //public char n3;

    //public void VINHOANG(char nuocmia)
    //{
    // n1 = nuocmia;
    //}
    //public void VINHHOANG(char nuocmia, char nuocdua)
    //{
    // n2 = nuocdua;
    //}
    //public void VINHHOANG(char nuocmia, char nuocdua, char suachua)
    //{
    //  n3 = suachua;
    // }
    //}
    class THONG1
    {
        public void ShowMenu()
        {
            Console.WriteLine("=== MENU ORDER NUOC GIAI KHAT ===");
            Console.WriteLine("1. Nuoc Mia");
            Console.WriteLine("2. Nuoc Dua");
            Console.WriteLine("3. Nuoc Cam");
            Console.WriteLine("END GAME");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int TotalCost = 0;
            THONG1 myProgram = new THONG1();
            myProgram.ShowMenu();
            //THONG p = new THONG();

        Batdau:
            Console.Write("Nhap so di thay =)): ");
            int chooseMenu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Command: {0}", chooseMenu);
            while (chooseMenu != 4)
            {
                if (chooseMenu > 4 || chooseMenu < 0)
                {
                    Console.WriteLine("Cu phap tam bay :))");
                }
                else
                {
                    switch (chooseMenu)
                    {
                        case 1:
                            TotalCost += 10; //Gia tien 
                            Console.WriteLine("Order nuoc mia thanh cong");
                            break;
                        case 2:
                            TotalCost += 20;
                            Console.WriteLine("Order nuoc dua thanh cong");
                            break;
                        case 3:
                            TotalCost += 30;
                            Console.WriteLine("Order nuoc cam thanh cong");
                            break;
                        case 4: break;
                        default:
                            break;
                    }
                    if (chooseMenu == 4) break;
        Lamlai:
                    Console.WriteLine("Muon uong nuoc nua khong?? - YES or NO? \nBam so 1 de chon YES \nBam so 2 de chon NO");
                    string User = Console.ReadLine();

                    switch (User.ToUpper())
                    {
                        case "1":
                            goto Batdau;
                        case "2":
                            break;
                        default:
                            Console.WriteLine("Nhap sai roi kia thay, nhap lai di thay oi");
                            goto Lamlai;
                    }
                    Console.WriteLine("Cam on da ghe shop nha thay :))");
                    Console.WriteLine("Tong tien hoa don cua thay HOANG NHU VINH la = {0} ngan dong", TotalCost);
                    Console.ReadLine();
                    Console.ReadKey();
                }
            }
        }
    }
}
