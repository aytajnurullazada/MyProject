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
                }
            } while (selectInt != 0);
        }
        static void SaleOperation()
        {
            int selectInt;
            do
            {
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

                }


            } while (selectInt != 0);
        }

        #region show methods

        #region Product's Methods
        static void AddProduct()
        {
            Console.WriteLine("Yeni satish daxil edin");
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
            while(!int.TryParse(Count1, out Count2))
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
            Console.WriteLine("Kateqoriya daxil edin");
            Array array = Enum.GetValues(typeof(Category));
            foreach (var item in array)
            {
                Console.Write(Array.IndexOf(array, item) + 1);
                Console.WriteLine("-{0}", item);
            }


            int Selection = Convert.ToInt32(Console.ReadLine());



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
                    Console.WriteLine("Sehv reqem daxil elemisiz tezden edin");
                    AddProduct();
                    break;

            }
            #endregion
            Console.WriteLine("Mehsul elave olundu");
        }
        static void SearchProductByName()
        {
           Console.Write("Axtarish etmek istediyiniz mehsulun adini qeyd edin: ");
           string Text =  Console.ReadLine();          
           var list = marketableService.SearchProductByName(Text);

            var table = new ConsoleTable("Mehsul", "Mehsulun adi", "Mehsulun Kodu", "Mehsulun sayi", "Mehsulun qiymeti", "Mehsulun Kateqoriyasi");
            int i = 1;
            foreach (var item in list)
            {
                _ = table.AddRow(i, item.ProductName, item.ProductCode, item.ProductCount, item.ProductPrice, item.Category);
                i++;
            }

            table.Write();
        }
        static void ChangeProduct()
        {
            Product product = new Product();
            List<Product> productList = new List<Product>();
            Console.WriteLine("Mehsulun kodunu daxil edin");
            string Code =  Console.ReadLine();
            Console.WriteLine("Mehsulun yeni adini daxil edin");
            string NewName = Console.ReadLine();
            Console.WriteLine("Yeni qiymet daxil edin");
            double NewPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yeni say daxil edin");
            int NewCount = Convert.ToInt32(Console.ReadLine());
            #region category
            Console.WriteLine("Kateqoriya sechin");
            Array array = Enum.GetValues(typeof(Category));
            foreach (var item2 in array)
            {
                Console.Write(Array.IndexOf(array, item2) + 1);
                Console.WriteLine("-{0}", item2);
            }
            int Selection = Convert.ToInt32(Console.ReadLine());
        

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
            foreach (var item in productList)
            {
                item.ProductName = NewName;                
                item.ProductPrice = NewPrice;                
                item.ProductCount = NewCount;
                item.Category = product.Category;

            }

            Console.WriteLine("Yeni mehsul elave olundu");

        }
        static void RemoveProduct()
        {
            List<Product> product = new List<Product>();
            
                Console.WriteLine("Silmek istediyiniz mehsulun kodunu yazin");
                string text = Console.ReadLine();
                marketableService.RemoveProduct(text);
            
        }
        static void GetProductByAmountRange()
        {
            Console.WriteLine("Min mebleq daxil edin");
            double minAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Max mebleq daxil edin");
            double maxAmount = Convert.ToDouble(Console.ReadLine());
            var list = marketableService.GetProductByAmountRange(minAmount, maxAmount);
            
            var table = new ConsoleTable("Mehsul", "Mehsulun adi", "Mehsulun Kodu", "Mehsulun sayi", "Mehsulun qiymeti", "Mehsulun Kateqoriyasi");
            int i = 1;
            foreach (var item in list)
            {
                _ = table.AddRow(i, item.ProductName, item.ProductCode, item.ProductCount, item.ProductPrice, item.Category);
                i++;
            }

            table.Write();

        }
        static void ShowProduct()
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
        static void GetProductByCategory()
        {
            
            Console.WriteLine("1 - Ichkiler");
            Console.WriteLine("2 - Meyveler");
            Console.WriteLine("3 - Yaglar");
            Console.WriteLine("4 - UnMehsullari");
            Console.WriteLine("5 - Terevezler");
            Console.WriteLine("6 - Shokoladlar");

            Console.WriteLine("Seçimek istediyiniz kategoriyanin nomresini qeyd edin");
            string select = Console.ReadLine();
            int selectInt;
            Product product = new Product();
            
            while (!int.TryParse(select, out selectInt))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz!");
                select = Console.ReadLine();
            }
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
                default:
                    Console.WriteLine("Sehv reqem daxil elemisiz tezden edin");
                    AddProduct();
                    break;
            }
            var list = marketableService.GetProductByCategory(product.Category);
            var table = new ConsoleTable("Mehsul", "Mehsulun adi", "Mehsulun Kodu", "Mehsulun sayi", "Mehsulun qiymeti", "Mehsulun Kateqoriyasi");
            int i = 1;
            foreach (var item in list)
            {
                _ = table.AddRow(i, item.ProductName, item.ProductCode, item.ProductCount, item.ProductPrice, item.Category);
                i++;
            }

            table.Write();
            
            
        } 
        #endregion

        #region Sale's Methods

        static void AddSale()
        {
            Console.WriteLine("Mehsulun kodunu daxil edin");
            string Code = Console.ReadLine();
            Console.WriteLine("Mehsulun sayini qeyd edin");
            int Count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mehsulun nomresini qeyd edin");
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
