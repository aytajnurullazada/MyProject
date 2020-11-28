using ConsoleProject.Infrustructure.Enums;
using ConsoleProject.Infrustructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Infrustructure.Interfaces
{
    interface IMarketable
    {
        //Sale's
        List<Sales> Sales { get; }      
        void AddSale(String Code, int Count, int Number);       
        void RemoveProductBySale(string Name, int Count);
        void GetTotalSale();
        List <Sales> GetSaleByDateRange(DateTime startDate, DateTime endDate);
        List <Sales> GetSaleByDate(DateTime Date);
        List <Sales> GetSaleByAmountRange(double FirstAmount, double LastAmount);
        List<Sales> GetSaleByNumber(int Number);
        //Product's 
        List<Product> Product { get; }
        void AddProduct(Product product);
        List<Product> ChangeProduct(string Code);
        List <Product> GetProductByCategory(Category CategoryNumber);
        List <Product> GetProductByAmountRange(double MinAmount, double MaxAmount);
        List <Product> SearchProductByName(String Text);
        void RemoveProduct(string Code);
        void ShowProduct();
    }
}
