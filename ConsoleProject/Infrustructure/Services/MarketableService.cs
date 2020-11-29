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
                    SaleNumber = 5,
                   SaleItems=new List<SaleItem>()
                   {
                       new SaleItem
                       {
                           ItemCount=2,
                           ItemNumber=4,
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
        public void AddSale(string Code, int Count, int Number)
        {                     
            List<Product> products = new List<Product>();
            Product product =  products.Find(p => p.ProductCode == Code);
            List<SaleItem> saleItems = new List<SaleItem>();
            SaleItem saleItem = new SaleItem();
            saleItem.Product = product;
            saleItem.ItemCount = Count;
            saleItem.ItemNumber = Number;
            saleItems.Add(saleItem);
            List<Sales> sales = new List<Sales>();
            
        }
        public void RemoveProductBySale(string Name, int Count)
        {
            
        }
        public void GetTotalSale()
        {        
        }
        public List<Sales> GetSaleByDateRange(DateTime StartDate, DateTime EndDate)
        {
            var list = _sales.Where(s => s.SaleDate >= StartDate && s.SaleDate <= EndDate).ToList();
            
            return list;
        }
        public List<Sales> GetSaleByNumber(int Number)
        {
            var list = Sales.Where(s => s.SaleNumber == Number).ToList();           
            return list;
        }
        public List<Sales> GetSaleByAmountRange(double FirstAmount, double LastAmount)
        {
            var list = Sales.Where(s => s.SaleAmount >= FirstAmount && s.SaleAmount <= LastAmount).ToList();           
            return list;
        }
        public List<Sales> GetSaleByDate(DateTime Date)
        {
            var list = _sales.Where(s => s.SaleDate == Date).ToList();         
            return list;
        }
        #endregion

        #region Product method
        public void AddProduct(Product product)
        {
            _product.Add(product);
        }

        public List<Product> ChangeProduct(String Code)
        {      
            return _product.FindAll(p => p.ProductCode == Code).ToList();

        }

        public List<Product> SearchProductByName(string Text)
        {
            return  _product.FindAll(p => p.ProductName.Contains(Text)).ToList();

         }

        public List<Product> GetProductByAmountRange(double MinAmount, double MaxAmount)
        {
            return _product.Where(p => p.ProductPrice >= MinAmount && p.ProductPrice <= MaxAmount).ToList();         

        }

        public void RemoveProduct(string code)
        {
            List<Product> products = _product.ToList();
            var res = products.Find(p => p.ProductCode == code);
            _product.Remove(res);
            
        }

        public List<Product> ShowProduct()
        {
           var list = _product.ToList();
            return list;
        }

        public List<Product> GetProductByCategory(Category CategoryNumber)
        {
            return _product.Where(p => p.Category == CategoryNumber).ToList();
            
        }
        #endregion
    }
}

