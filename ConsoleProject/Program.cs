using System;
using System.Text;
using ConsoleProject.Infrustructure.Services;
using System.Collections.Generic;


namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
            
        {
            MarketableService aaa = new MarketableService();

            aaa.SearchProductByName("Lay");
            
            

        //    Console.OutputEncoding = Encoding.UTF8;
        //    int selectInt;
        //    do
        //    {
        //        #region Menu
        //        Console.WriteLine("========== Market İdarə Etmək Sistemi ==========");
        //        Console.WriteLine("- 1 Məhsullar üzərində əməliyyat aparmaq");
        //        Console.WriteLine("- 2 Satışlar üzərində əməliyyat aparmaq");
        //        Console.WriteLine("- 0 Sistemdən çıxmaq");
        //        #endregion

        //        #region Menu Selection
        //        Console.WriteLine("Seçiminizi edin :");
        //        string select = Console.ReadLine();

        //        while (!int.TryParse(select, out selectInt))
        //        {
        //            Console.WriteLine("Rəqəm daxil etməlisiniz!");
        //            select = Console.ReadLine();
        //        }
        //        #region Menu Switch
        //        switch (selectInt)
        //        {
        //            case 0:
        //                continue;
        //            case 1:
        //                ProductOperation();
        //            break;
        //            case 2:
        //                SaleOperation();
        //            break;

        //        }
        //        #endregion
        //        #endregion

        //    } while (selectInt != 0);
        //}
        //static void ProductOperation()
        //{
        //    int selectInt;
        //    do
        //    {
        //        Console.WriteLine("- 1 Yeni mehsul elave et");
        //        Console.WriteLine("- 2 Mehsul uzerinde duzelish et");
        //        Console.WriteLine("- 3 Mehsulu sil");
        //        Console.WriteLine("- 4 Butun mehsullari goster");
        //        Console.WriteLine("- 5 Categoriyasina gore mehsullari goster");
        //        Console.WriteLine("- 6 Qiymet araligina gore mehsullari goster");
        //        Console.WriteLine("- 7 Mehsullar arasinda ada gore axtaris et");
        //        Console.WriteLine("- 0 Geri qayitmaq");

        //        Console.WriteLine("Seçiminizi edin :");
        //        string select = Console.ReadLine();

        //        while (!int.TryParse(select, out selectInt))
        //        {
        //            Console.WriteLine("Rəqəm daxil etməlisiniz!");
        //            select = Console.ReadLine();
        //        }
        //        switch (selectInt)
        //        {
        //            case 0:
        //                continue;
        //            case 1:
        //                Console.WriteLine("1");
        //                break;
        //            case 2:
        //                Console.WriteLine("1");
        //                break;
        //            case 3:
        //                Console.WriteLine("1");
        //                break;
        //            case 4:
        //                Console.WriteLine("1");
        //                break;
        //            case 5:
        //                Console.WriteLine("1");
        //                break;
        //            case 6:
        //                Console.WriteLine("1");
        //                break;
        //            case 7:
        //                Console.WriteLine("1");
        //                break;


        //        }
                

        //    } while (selectInt != 0);


        //}

        //static void SaleOperation()
        //{
        //    int selectInt;
        //    do
        //    {
        //        Console.WriteLine("- 1 Yeni satis elave etmek");
        //        Console.WriteLine("- 2 Satisdaki hansisa mehsulun geri qaytarilmasi");
        //        Console.WriteLine("- 3 Satisin silinmesi");
        //        Console.WriteLine("- 4 Butun satislarin ekrana cixarilmasi");
        //        Console.WriteLine("- 5 Verilen tarix araligina gore satislarin gosterilmesi");
        //        Console.WriteLine("- 6 Verilen mebleg araligina gore satislarin gosterilmesi");
        //        Console.WriteLine("- 7 Verilmis bir tarixde olan satislarin gosterilmesi");
        //        Console.WriteLine("- 8 Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi");
        //        Console.WriteLine("- 0 Geri qayitmaq");
        //        Console.WriteLine("Seçiminizi edin :");
        //        string select = Console.ReadLine();

        //        while (!int.TryParse(select, out selectInt))
        //        {
        //            Console.WriteLine("Rəqəm daxil etməlisiniz!");
        //            select = Console.ReadLine();
        //        }
        //        switch (selectInt)
        //        {
        //            case 0:
        //                continue;
        //            case 1:
        //                Console.WriteLine("1");
        //                break;
        //            case 2:
        //                Console.WriteLine("2");
        //                break;
        //            case 3:
        //                Console.WriteLine("3");
        //                break;
        //            case 4:
        //                Console.WriteLine("4");
        //                break;
        //            case 5:
        //                Console.WriteLine("5");
        //                break;
        //            case 6:
        //                Console.WriteLine("6");
        //                break;
        //            case 7:
        //                Console.WriteLine("7");
        //                break;


        //        }


        //    } while (selectInt != 0);
        }
    }
}
