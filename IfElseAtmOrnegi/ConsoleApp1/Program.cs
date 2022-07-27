using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double bakiyem = 1260.5;
            while (true)
            {
                int secilenİslem = anaMenu();

                if (secilenİslem == 1)
                {
                    Console.WriteLine("Toplam bakiyeniz: " + bakiyem + " " + "TL'dir.");
                    Console.WriteLine("");
                }
                else if (secilenİslem == 2)
                {
                    Console.Write("Lütfen Yatırmak istediğiniz tutarı giriniz: ");
                    double yatırılanTutar = Convert.ToDouble(Console.ReadLine());
                    bakiyem = yatırılanTutar + bakiyem;
                    Console.WriteLine("İşleminiz gerçekleştirilmiştir..Toplam bakiyeniz: " + bakiyem + " " + "TL'dir.");
                    Console.WriteLine("");
                }
                else if (secilenİslem == 3)
                {
                    Console.Write("Lütfen çekmek istediğiniz tutarı giriniz: ");
                    double cekilecekTutar = Convert.ToDouble(Console.ReadLine());

                    if (cekilecekTutar > bakiyem)
                    {
                        Console.WriteLine("Yetersiz bakiye!");
                    }
                    else
                    {
                        bakiyem = bakiyem - cekilecekTutar;
                        Console.WriteLine("İşleminiz gerçekleştirilmiştir..Toplam bakiyeniz: " + bakiyem + " " + "TL'dir.");
                        Console.WriteLine("");
                    }
                }
                else if (secilenİslem == 4)
                {
                    Console.WriteLine("Çıkış işlemi gerçekleştirilmiştir.");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı işlem yaptınız.");
                    Console.WriteLine("");
                }
            }
        }
        static int anaMenu()
        {
            Console.WriteLine("1-Bakiye görüntüleme");
            Console.WriteLine("2-Para Yatırma");
            Console.WriteLine("3-Para çekme");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen bir işlemi seçiniz: ");

            int islemSec = Convert.ToInt32(Console.ReadLine());
            return islemSec;
        }
    }

}
