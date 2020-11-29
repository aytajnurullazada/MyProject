using System;
using System.Text;
using ConsoleProject.Infrustructure.Services;
using System.Collections.Generic;
using ConsoleProject.Infrustructure.Models;
using ConsoleProject.Infrustructure.Enums;
using ConsoleTables;

namespace ConsoleProject
{
    class Program
    {
        private static readonly MarketableService marketableService = new MarketableService();
        static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.UTF8;
            int selectInt;
            do
            {
                #region Menu
                Console.WriteLine("========== Market İdarə Etmək Sistemi ==========");
                Console.WriteLine("- 1 Məhsullar üzərində əməliyyat aparmaq");
                Console.WriteLine("- 2 Satışlar üzərində əməliyyat aparmaq");
                Console.WriteLine("- 0 Sistemdən çıxmaq");
                #endregion

                #region Menu Selection
                Console.WriteLine("Seçiminizi edin :");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");
                    select = Console.ReadLine();
                }
                #region Menu Switch
                switch (selectInt)
                {
                    case 0:
                        continue;
                    case 1:
                        ProductOperation();
                        break;
                    case 2:
                        SaleOperation();
                        break;
                    default:
                        Console.WriteLine("Uygun reqem daxil edin");
                        break;

                }
                #endregion
                #endregion

            } while (selectInt != 0);
        }
        static void ProductOperation()
        {
            int selectInt;
            do
            {
                #region Menu
                Console.WriteLine("- 1 Yeni mehsul elave et");
                Console.WriteLine("- 2 Mehsul uzerinde duzelish et");
                Console.WriteLine("- 3 Mehsulu sil");
                Console.WriteLine("- 4 Butun mehsullari goster");
                Console.WriteLine("- 5 Categoriyasina gore mehsullari goster");
                Console.WriteLine("- 6 Qiymet araligina gore mehsullari goster");
                Console.WriteLine("- 7 Mehsullar arasinda ada gore axtaris et");
                Console.WriteLine("- 0 Geri qayitmaq");

                Console.WriteLine("Seçiminizi edin :");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");
                    select = Console.ReadLine();
                }
                #endregion
                #region Menu Select
                switch (selectInt)
                {
                    case 0:
                        continue;
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        ChangeProduct();
                        break;
                    case 3:
                        RemoveProduct();
                        break;
                    case 4:
                        ShowProduct();
                        break;
                    case 5:
                        GetProductByCategory();
                        break;
                    case 6:
                        GetProductByAmountRange();
                        break;
                    case 7:
                        SearchProductByName();
                        break;
                    default:
                        Console.WriteLine("Uygun reqem daxil edin");
                        break;
                }
                #endregion
            }
            while (selectInt != 0);
        }
        static void SaleOperation()
        {
            int selectInt;
            do
            {
                #region Menu
                Console.WriteLine("- 1 Yeni satis elave etmek");
                Console.WriteLine("- 2 Satisdaki hansisa mehsulun geri qaytarilmasi");
                Console.WriteLine("- 3 Satisin silinmesi");
                Console.WriteLine("- 4 Butun satislarin ekrana cixarilmasi");
                Console.WriteLine("- 5 Verilen tarix araligina gore satislarin gosterilmesi");
                Console.WriteLine("- 6 Verilen mebleg araligina gore satislarin gosterilmesi");
                Console.WriteLine("- 7 Verilmis bir tarixde olan satislarin gosterilmesi");
                Console.WriteLine("- 8 Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi");
                Console.WriteLine("- 0 Geri qayitmaq");
                Console.WriteLine("Seçiminizi edin :");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");
                    select = Console.ReadLine();
                }
                #endregion
                #region Menu select
                switch (selectInt)
                {
                    case 0:
                        continue;
                    case 1:
                        AddSale();
                        break;
                    case 2:
                        Console.WriteLine("2");
                        break;
                    case 3:
                        Console.WriteLine("3");
                        break;
                    case 4:
                        ShowSale();
                        break;
                    case 5:
                        GetSaleByDateRange();
                        break;
                    case 6:
                        GetSaleByAmountRange();
                        break;
                    case 7:
                        GetSaleByDate();
                        break;
                    case 8:
                        GetSaleByNumber();
                        break;
                    default:
                        Console.WriteLine("Uygun reqem daxil edin");
                        break;

                }

                #endregion

            } while (selectInt != 0);
        }

        #region show methods

        #region Product's Methods
        static void AddProduct()
        {
            Console.WriteLine("=========Yeni mehsul daxil edin=========");
            Product product = new Product();

            #region Name
            Console.WriteLine("Məhsul adı daxil edin :");
            product.ProductName = Console.ReadLine();
            #endregion
            #region price
            Console.WriteLine("Mehsulun qiymetini daxil edin");
            string Price = Console.ReadLine();
            double PriceDouble;
            while (!double.TryParse(Price, out PriceDouble))
            {
                Console.WriteLine("Duzgun reqem daxil edin");
                Price = Console.ReadLine();

            }

            product.ProductPrice = PriceDouble;

            #endregion
            #region Count
            Console.WriteLine("Say daxil edin");
            string Count1 = Console.ReadLine();
            int Count2;
            while (!int.TryParse(Count1, out Count2))
            {
                Console.WriteLine("Duzgun say daxil edin");
                Count1 = Console.ReadLine();
            }
            product.ProductCount = Count2;
            #endregion
            #region Code
            Console.WriteLine("Mehsulun kodunu daxil edin");
            product.ProductCode = Console.ReadLine();
            #endregion
            #region Category        
            Console.WriteLine("Sechmek istediyiniz kateqoriyanin qarshisindaki reqemi qeyd edin");
                Array array = Enum.GetValues(typeof(Category));
                foreach (var item in array)
                {
                    Console.Write(Array.IndexOf(array, item) + 1);
                    Console.WriteLine("-{0}", item);
                }
                int Selection;
                string Select = Console.ReadLine();
                while (!int.TryParse(Select, out Selection))
                {
                    Console.WriteLine("Reqem daxil etmelisiniz");
                    Select = Console.ReadLine();
                }
                switch (Selection)
                {
                    case 1:
                        product.Category = Category.Ichkiler;
                        break;
                    case 2:
                        product.Category = Category.Meyveler;
                        break;
                    case 3:
                        product.Category = Category.Shokoladlar;
                        break;
                    case 4:
                        product.Category = Category.Terevezler;
                        break;
                    case 5:
                        product.Category = Category.UnMehsullari;
                        break;
                    case 6:
                        product.Category = Category.Yaglar;
                        break;
                        default:
                        Console.WriteLine("Bele bir kateqoriya yoxdur");
                        AddProduct();
                        break;
                }
            


            #endregion
            marketableService.AddProduct(product);
            Console.WriteLine("=========Mehsul elave olundu=========");
        }
        static void SearchProductByName()
        {
           Console.Write("Axtarish etmek istediyiniz mehsulun adini qeyd edin: ");
           string Text =  Console.ReadLine();          
           var list = marketableService.SearchProductByName(Text);
            if (list.Count == 0)
            {
                Console.WriteLine("Bu adda mehsul yoxdur");
            }
            else
            {
                var table = new ConsoleTable("Mehsul", "Mehsulun adi", "Mehsulun Kodu", "Mehsulun sayi", "Mehsulun qiymeti", "Mehsulun Kateqoriyasi");
                int i = 1;
                foreach (var item in list)
                {
                    _ = table.AddRow(i, item.ProductName, item.ProductCode, item.ProductCount, item.ProductPrice, item.Category);
                    i++;
                }

                table.Write();
            }
                
            
        } 
        static void ChangeProduct()
        {
            Product product = new Product();
            List<Product> productList = new List<Product>();           
            Console.WriteLine("Mehsulun kodunu daxil edin");
            string Code =  Console.ReadLine();
            var list = marketableService.ChangeProduct(Code);
            
            if (list.Count == 0)
            {
               Console.WriteLine("Bu koda uygun mehsul yoxdur");
            }
            else
            {
                #region Name
                Console.WriteLine("Mehsulun yeni adini daxil edin");
                string NewName = Console.ReadLine();
                #endregion
                #region Price
                Console.WriteLine("Yeni qiymet daxil edin");
                string Price = Console.ReadLine();
                double NewPrice;
               
                while (!double.TryParse(Price, out NewPrice))
                {
                    Console.WriteLine("Duzgun qiymet daxil edin");
                    Price = Console.ReadLine();
                }
                product.ProductPrice = NewPrice;
                #endregion
                #region Count
                Console.WriteLine("Yeni say daxil edin");
                string Count = Console.ReadLine();
                int NewCount;
                while (!int.TryParse(Count, out NewCount))
                {
                    Console.WriteLine("Duzgun say daxil edin");
                    Count = Console.ReadLine();
                }
                #endregion
                #region category
                Console.WriteLine("Kateqoriya sechin");
                Array array = Enum.GetValues(typeof(Category));
                foreach (var item2 in array)
                {
                    Console.Write(Array.IndexOf(array, item2) + 1);
                    Console.WriteLine("-{0}", item2);
                }                
                int Selection;
                string Select = Console.ReadLine();
                while (!int.TryParse(Select, out Selection))
                {
                    Console.WriteLine("Reqem daxil etmelisiniz");
                    Select = Console.ReadLine();
                }

                switch (Selection)
                {
                    case 1:
                        product.Category = Category.Ichkiler;
                        break;
                    case 2:
                        product.Category = Category.Meyveler;
                        break;
                    case 3:
                        product.Category = Category.Shokoladlar;
                        break;
                    case 4:
                        product.Category = Category.Terevezler;
                        break;
                    case 5:
                        product.Category = Category.UnMehsullari;
                        break;
                    case 6:
                        product.Category = Category.Yaglar;
                        break;
                    default:
                        Console.WriteLine("Kateqoriyanin qarshisindaki reqemi daxil edin");
                        break;
                }


                #endregion
                foreach (var item in list)
                {
                    item.ProductName = NewName;
                    item.ProductPrice = NewPrice;
                    item.ProductCount = NewCount;
                    item.Category = product.Category;

                }
                marketableService.ChangeProduct(Code);
                Console.WriteLine("=======Mehsul deyishdirildi=======");
            } 
        }
        static void RemoveProduct()
        {
                List<Product> product = new List<Product>();
            
                Console.WriteLine("Silmek istediyiniz mehsulun kodunu yazin");
                string text = Console.ReadLine();
                //Console.WriteLine("Bu koda uygun mehsul yoxdur");
            
                marketableService.RemoveProduct(text);
                Console.WriteLine("=======Mehsul silindi=======");
            
        }
        static void GetProductByAmountRange()
        {
            Console.WriteLine("Min mebleq daxil edin");
            string Amount = Console.ReadLine();
            double minAmount;
            while(!double.TryParse(Amount, out minAmount))
            {
                Console.WriteLine("Duzgun mebleg daxil edin");
                Amount = Console.ReadLine();
            }
            Console.WriteLine("Max mebleq daxil edin");
            string Amount2 = Console.ReadLine();
            double maxAmount;
            while (!double.TryParse(Amount2, out maxAmount))
            {
                Console.WriteLine("Duzgun mebleg daxil edin");
                Amount2 = Console.ReadLine();
            }
            if (maxAmount < minAmount)
            {
                Console.WriteLine("Max mebleg Min mebleqden boyuk olmalidir");
            }
            else
            {

                var list = marketableService.GetProductByAmountRange(minAmount, maxAmount);
                if (list.Count == 0)
                {
                    Console.WriteLine("Mehsul yoxdur");
                }
                else
                {
                    var table = new ConsoleTable("Mehsul", "Mehsulun adi", "Mehsulun Kodu", "Mehsulun sayi", "Mehsulun qiymeti", "Mehsulun Kateqoriyasi");
                    int i = 1;
                    foreach (var item in list)
                    {
                        _ = table.AddRow(i, item.ProductName, item.ProductCode, item.ProductCount, item.ProductPrice, item.Category);
                        i++;
                    }

                    table.Write();
                }
            }
        }
        static void ShowProduct()
        {
            List<Product> product = new List<Product>();
            var list = marketableService.ShowProduct();
            if (list.Count == 0)
            {
                Console.WriteLine("Mehsul yoxdur");
            }
            else
            {
                var table = new ConsoleTable("Mehsul", "Mehsulun adi", "Mehsulun Kodu", "Mehsulun sayi", "Mehsulun qiymeti", "Mehsulun Kateqoriyasi");
                int i = 1;
                foreach (var item in marketableService.Product)
                {
                    table.AddRow(i, item.ProductName, item.ProductCode, item.ProductCount, item.ProductPrice, item.Category);
                    i++;
                }

                table.Write();
            }
        }
        static void GetProductByCategory()
        {
            int selectInt;
             
            #region menu
            Console.WriteLine("Seçmek istediyiniz kategoriyanin nomresini qeyd edin");

                Console.WriteLine("1 - Ichkiler");
                Console.WriteLine("2 - Meyveler");
                Console.WriteLine("3 - Yaglar");
                Console.WriteLine("4 - UnMehsullari");
                Console.WriteLine("5 - Terevezler");
                Console.WriteLine("6 - Shokoladlar");
                Console.WriteLine("0 - Geri qayitmaq");

                string select = Console.ReadLine();

                Product product = new Product();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz");
                    select = Console.ReadLine();
                }
            #endregion
            #region Menu Select
            switch (selectInt)
                {
                    case 1:
                        product.Category = Category.Ichkiler;
                        break;
                    case 2:
                        product.Category = Category.Meyveler;
                        break;
                    case 3:
                        product.Category = Category.Yaglar;
                        break;
                    case 4:
                        product.Category = Category.UnMehsullari;
                        break;
                    case 5:
                        product.Category = Category.Terevezler;
                        break;
                    case 6:
                        product.Category = Category.Shokoladlar;
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("1-6 arasi reqem daxil edilmelidir");
                        break;
                }
                if (selectInt >= 1 && selectInt <= 6)
                {

                    var list = marketableService.GetProductByCategory(product.Category);
                    if (list.Count == 0)
                    {
                        Console.WriteLine("Bu kateqoriyaya uygun mehsul yoxdur");
                    }
                    else
                    {
                        var table = new ConsoleTable("Mehsul", "Mehsulun adi", "Mehsulun Kodu", "Mehsulun sayi", "Mehsulun qiymeti", "Mehsulun Kateqoriyasi");
                        int i = 1;
                        foreach (var item in list)
                        {
                            _ = table.AddRow(i, item.ProductName, item.ProductCode, item.ProductCount, item.ProductPrice, item.Category);
                            i++;
                        }

                        table.Write();
                    }
                }
            #endregion
            
        }
        #endregion

        #region Sale's Methods

        static void AddSale()
        {
            Console.WriteLine("Satishin kodunu daxil edin");
            string Code = Console.ReadLine();
            Console.WriteLine("Satishin sayini qeyd edin");
            int Count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Satishin nomresini qeyd edin");
            int number = Convert.ToInt32(Console.ReadLine());
            marketableService.AddSale(Code, Count, number);
            
        }
        static void ShowSale()
        {
            marketableService.GetTotalSale();
            var table = new ConsoleTable("Satish" , "Satish Meblegi", "Satish Tarixi", "Satish sayi", "Satish Nomresi" );
            int i = 1;
            foreach (var item in marketableService.Sales)
            {
                _ = table.AddRow(i, item.SaleAmount, item.SaleDate.ToString("dd.MM.yyyy"), item.SaleItems.Count, item.SaleNumber);
                i++;
            }

            table.Write();

        }
        static void GetSaleByDateRange()
        {
            Console.WriteLine("Bashlangic tarixi qeyd edin");
            DateTime StartDate = Convert.ToDateTime( Console.ReadLine());
            Console.WriteLine("Bitish tarixini qeyd edin");
            DateTime EndDate = Convert.ToDateTime(Console.ReadLine());
            var table = new ConsoleTable("Satish", "Satish Meblegi", "Satish Tarixi", "Satish sayi", "Satish Nomresi");
            int i = 1;
            var list = marketableService.GetSaleByDateRange(StartDate, EndDate);
            foreach (var item in list)
            {
                table.AddRow(i, item.SaleAmount, item.SaleDate.ToString("dd.MM.yyyy"), item.SaleItems.Count, item.SaleNumber);
                i++;
            }

            table.Write();          
        }
        static void GetSaleByAmountRange()
        {
            Console.WriteLine("1-ci meblegi sechin");
            double FirstAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2-ci meblegi sechin");
            double LastAmount = Convert.ToDouble(Console.ReadLine());
            var table = new ConsoleTable("Satish", "Satish Meblegi", "Satish Tarixi", "Satish sayi", "Satish Nomresi");
            int i = 1;
            var list = marketableService.GetSaleByAmountRange(FirstAmount, LastAmount);
            foreach (var item in list)
            {
                _ = table.AddRow(i, item.SaleAmount, item.SaleDate.ToString("dd.MM.yyyy"), item.SaleItems.Count, item.SaleNumber);
                i++;
            }

            table.Write();
            
        }
        static void GetSaleByDate()
        {
            Console.WriteLine("Tarix qeyd edin");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            List<Sales> result = marketableService.GetSaleByDate(date);
            var table = new ConsoleTable("Satish", "Satish Meblegi", "Satish Tarixi", "Satish sayi", "Satish Nomresi");
            int i = 1;
            var list = marketableService.GetSaleByDate(date);
            foreach (var item in list)
            {
                _ = table.AddRow(i, item.SaleAmount, item.SaleDate.ToString("dd.MM.yyyy"), item.SaleItems.Count, item.SaleNumber);
                i++;
            }
            table.Write();
            
        }
        static void GetSaleByNumber()
        {
            Console.WriteLine("Nomre daxil edin");
            int Number = Convert.ToInt32(Console.ReadLine());
            List<Sales> result = marketableService.GetSaleByNumber(Number);
            var table = new ConsoleTable("Satish", "Satish Meblegi", "Satish Tarixi", "Satish sayi", "Satish Nomresi");
            int i = 1;
            var list = marketableService.GetSaleByNumber(Number);
            foreach (var item in list)
            {
                _ = table.AddRow(i, item.SaleAmount, item.SaleDate.ToString("dd.MM.yyyy"), item.SaleItems.Count, item.SaleNumber);
                i++;
            }

            table.Write();
        }
        #endregion

        #endregion

    }
}
