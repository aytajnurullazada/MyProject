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
        private readonly List<Sales> _sales;
        public List<Sales> Sales => _sales;



        //private readonly List<Product> _product;


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
        
            

        public List<Product> Product => _product;

        public void AddSale(Sales sale)
        {
            _sales.Add(sale);
        }

        public void RemoveProductBySale(string Name, int Count)
        {
            throw new NotImplementedException();
        }

        public void GetTotalSale()
        {
            throw new NotImplementedException();
        }


        public void GetSaleByAmountRange(double FirstAmount, double LastAmount)
        {
            throw new NotImplementedException();
        }

        public void GetSaleByNumber(int Number)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            _product.Add(product);
        }

        public void ChangeProduct(String Code)
        {
            _product.FindAll(p => p.ProductCode == Code).Where(p => p.ProductName == Console.ReadLine()); 
            
           
        }

        public void SearchProductByName(string Text)
        {

            List<Product> Products = Product.FindAll(p => p.ProductName.Contains(Text));

                foreach (var item in Products)
                {
                    Console.WriteLine(item.ProductName);
                    Console.WriteLine(item.ProductCode);
                    Console.WriteLine(item.ProductCount);
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

        public List<Sales> GetSaleByDate(DateTime Date)
        {
            throw new NotImplementedException();
        }

        
    }    
    }

