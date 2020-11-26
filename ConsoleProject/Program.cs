using System;
using System.Text;
using ConsoleProject.Infrustructure.Services;
using System.Collections.Generic;
using ConsoleProject.Infrustructure.Models;
using ConsoleProject.Infrustructure.Enums;

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
                        Console.WriteLine("1");
                        break;
                    case 5:
                        Console.WriteLine("1");
                        break;
                    case 6:
                        Console.WriteLine("1");
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
                        Console.WriteLine("1");
                        break;
                    case 2:
                        Console.WriteLine("2");
                        break;
                    case 3:
                        Console.WriteLine("3");
                        break;
                    case 4:
                        Console.WriteLine("4");
                        break;
                    case 5:
                        Console.WriteLine("5");
                        break;
                    case 6:
                        Console.WriteLine("6");
                        break;
                    case 7:
                        Console.WriteLine("7");
                        break;


                }


            } while (selectInt != 0);
        }
        #region show methods
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
           string result = marketableService.SearchProductByName(Text);  
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
        
        
        #endregion
    }
}
