using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleProject.Infrustructure.Enums;
using ConsoleProject.Infrustructure.Interfaces;
using ConsoleProject.Infrustructure.Models;
using ConsoleProject.Infrustructure.Services;


namespace ConsoleProject.Infrustructure.Services
{
    public class MarketableService : IMarketable
    {
        #region Sales
        public List<Sales> _sales = new List<Sales>{
                new Sales
                {
                    SaleAmount = 23.4,
                    SaleDate = new DateTime(2020,09,09),
                    SaleNumber = 1,
                   SaleItems=new List<SaleItem>()
                   {
                       new SaleItem
                       {
                           ItemCount=1,
                           ItemNumber=1,
                             Product=new Product()
                           {
                                 ProductCount = 2,
                                 ProductCode ="23d1",
                                 ProductName = "Redbull",
                                 ProductPrice = 2.4,
                           }
                       }
                   }
                    
                }
            };
        #endregion

        #region Product
        public List<Product> _product = new List<Product>
        {
            new Product
            {
             ProductCode = "123",
             ProductCount = 4,
             ProductName = "Lays",
             ProductPrice = 1.2,
             Category = Category.Meyveler
            },
            new Product
        {
            ProductCode = "124",
            ProductCount = 2,
            ProductName = "Nutella",
            ProductPrice = 2.3,
            Category = Category.Shokoladlar
        },
            new Product
        {
            ProductCode = "125",
            ProductCount = 1,
            ProductName = "CocaCola",
            ProductPrice = 0.8,
            Category = Category.Ichkiler
        }

    };
        #endregion
        
        public List<Product> Product => _product;
        public List<Sales> Sales => _sales;

        #region Sales Method

        //AddSale method - adding sale
        public void AddSale(string Code, int Count)
        {
            List<SaleItem> saleItems = new List<SaleItem>();
            double amount = 0;
            var product = _product.Where(p => p.ProductCode == Code).FirstOrDefault();
            var saleItem = new SaleItem();
            var productCode = Code;
            saleItem.ItemCount = Count;
            saleItem.Product = product;
            saleItem.ItemNumber = saleItem.ItemCount + 1;
            saleItems.Add(saleItem);
            amount += Count * saleItem.Product.ProductPrice;
            var saleNumber = Sales.Count + 1;
            var saleDate = DateTime.Now;
            var sale = new Sales();
            sale.SaleAmount = amount;
            sale.SaleDate = saleDate;
            sale.SaleItems = saleItems;
            sale.SaleNumber = saleNumber;
            _sales.Add(sale);
        }
        // Remove Product From Sale
        public void RemoveProductFromSale(int Number,string Code, int Count)
        {
            List<Sales> sales = _sales.ToList();
            List<Product> products = _product.ToList();
            var sale = sales.Find(s => s.SaleNumber == Number);
            bool findNumber = sales.Exists(s => s.SaleNumber == Number);
            if (findNumber == false)
            {
                Console.WriteLine("Bu nomrede satish yoxdur");
            }
            else
            {
                var list = products.Find(p => p.ProductCode == Code);
                bool find = products.Exists(f => f.ProductCode == Code);
                if (find == false)
                {
                    Console.WriteLine("Bu kodda mehsul yoxdur");
                }
                else
                {
                    if (sale.SaleAmount > list.ProductPrice * Count)
                    {
                        sale.SaleAmount -= list.ProductPrice * Count;
                    }
                    else if ((sale.SaleAmount == list.ProductPrice * Count))
                    {

                        Console.WriteLine("Satışdan məhsul geri qaytarıldı");
                    }
                    else
                    {
                        Console.WriteLine("Mehsuldan bu qeder satilmayib");

                    }
                }
            }
        }
        //Remove Sale
        public void RemoveSale(int Number)
        {
            List<Sales> sales = _sales.ToList();
            var res = sales.Find(s => s.SaleNumber == Number);
            _sales.Remove(res);
            
        }
        //Show Total Sales
        public List<Sales> GetTotalSale()
        {
            var list = Sales.ToList();
            return list;
        }
        //User add 2 date and show Total Sale
        public List<Sales> GetSaleByDateRange(DateTime StartDate, DateTime EndDate)
        {
            var list = _sales.Where(s => s.SaleDate >= StartDate && s.SaleDate <= EndDate).ToList();
            
            return list;
        }
        //User add Sale Number and show total sale
        public List<Sales> GetSaleByNumber(int Number)
        {
            var list = Sales.Where(s => s.SaleNumber == Number).ToList();           
            return list;
        }
        //User add 2 Amount and show total sale
        public List<Sales> GetSaleByAmountRange(double FirstAmount, double LastAmount)
        {
            var list = Sales.Where(s => s.SaleAmount >= FirstAmount && s.SaleAmount <= LastAmount).ToList();           
            return list;
        }

        //User add date show total sale
        public List<Sales> GetSaleByDate(DateTime Date)
        {
            var list = _sales.Where(s => s.SaleDate == Date).ToList();         
            return list;
        }      
        #endregion

        #region Product method
        //user add Product
        public void AddProduct(Product product)
        {
            _product.Add(product);
        }
         //User can change product's informarion
        public List<Product> ChangeProduct(String Code)
        {      
            return _product.FindAll(p => p.ProductCode == Code).ToList();

        }
        //user can search product by adding name
        public List<Product> SearchProductByName(string Text)
        {
            return  _product.FindAll(p => p.ProductName.Contains(Text)).ToList();

         }

        //user add min and max amount and show total product
        public List<Product> GetProductByAmountRange(double MinAmount, double MaxAmount)
        {
            return _product.Where(p => p.ProductPrice >= MinAmount && p.ProductPrice <= MaxAmount).ToList();         

        }
//user add product code and can remove product
        public void RemoveProduct(string code)
        {
            List<Product> products = _product.ToList();
            var res = products.Find(p => p.ProductCode == code);
            _product.Remove(res);           
        }
        //Show all products
        public List<Product> ShowProduct()
        {
           var list = _product.ToList();
            return list;
        }
//user select category and show products form this category
        public List<Product> GetProductByCategory(Category CategoryNumber)
        {
            return _product.Where(p => p.Category == CategoryNumber).ToList();
        }

        public List<Product> GetProductByCode(string Code)
        {
            List<Product> products = _product.Where(p => p.ProductCode == Code).ToList();
            return products;
        }

        #endregion

    }
}

