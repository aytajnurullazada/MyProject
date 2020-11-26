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
                   
                    
                }
            };
        #endregion
        #region Sale item
        public List<SaleItem> _saleItem =  new List<SaleItem>{
        new SaleItem
        {       ItemCount = 3,
                ItemNumber=6,
                

        }
        };
        #endregion
        #region Product
        public List<Product> _product = new List<Product>
        {
            new Product
            {
             ProductCode = "347gshs833",
             ProductCount = 4,
             ProductName = "Lays",
             ProductPrice = 1.2
            },
            new Product
        {
            ProductCode = "4hr47re",
            ProductCount = 2,
            ProductName = "Nutella",
            ProductPrice = 2.3
        },
            new Product
        {
            ProductCode = "768473adsw",
            ProductCount = 1,
            ProductName = "CocaCola",
            ProductPrice = 0.8
        }

    };
        #endregion
        
        public List<Product> Product => _product;
        public List<Sales> Sales => _sales;

        public void AddSale(Sales sale)
        {
            _sales.Add(sale);
        }


        public void RemoveProductBySale(string Name, int Count)
        {
            
        }

        public void GetTotalSale()
        {
            throw new NotImplementedException();
        }


        public void GetSaleByAmountRange(double FirstAmount, double LastAmount)
        {
            
        }

        public void GetSaleByNumber(int Number)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            _product.Add(product);
        }

        public List<Product> ChangeProduct(String Code)
        {
        
            return _product.FindAll(p => p.ProductCode == Code).ToList();
           
        }

        public string SearchProductByName(string Text)
        {
            return _product.FindAll(p => p.ProductName.Contains(Text)).ToString();
               foreach(var item in _product)
            {
                Console.WriteLine(item.ProductCode);
                Console.WriteLine(item.ProductCount);
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.ProductPrice);
            }
           
            }

        List<Sales> IMarketable.GetSaleByDateRange(DateTime StartDate, DateTime EndDate)
        {
            return _sales.Where(s => s.SaleDate >= StartDate && s.SaleDate <= EndDate).ToList();
           
        }

        public List<Product> GetProductByAmountRange(double MinAmount, double MaxAmount)
        {
            return _product.Where(p => p.ProductPrice >= MinAmount && p.ProductPrice <= MaxAmount).ToList();
        }

        List<Product> IMarketable.GetProductByCategory(Category CategoryNumber)
        {
            return _product.FindAll(p => p.Category == CategoryNumber);

            foreach (var item in _product)
            {
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.ProductCode);
                Console.WriteLine(item.ProductCount);
                Console.WriteLine(item.ProductPrice);
            }
        }

        
        List<Sales> IMarketable.GetSaleByAmountRange(double FirstAmount, double LastAmount)
        {
            throw new NotImplementedException();
        }

        public List<Sales> GetSaleByDate(DateTime Date)
        {
            throw new NotImplementedException();
        }

      public void RemoveProduct(string code)
        {
            List<Product> products = _product.ToList();
           var res= products.Find(p => p.ProductCode == code);
         _product.Remove(res);
        }
    }    
    }

