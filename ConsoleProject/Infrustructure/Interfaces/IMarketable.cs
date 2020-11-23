using ConsoleProject.Infrustructure.Enums;
using ConsoleProject.Infrustructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Infrustructure.Interfaces
{
    interface IMarketable
    {
        List<Sales> Sales { get; }
        List<Product> Product { get; }
        void AddSale(string Name);
        void RemoveProductBySale(string Name, int Count);
        void GetTotalSale();
        void GetSaleByDateRange(DateTime StartDate, DateTime EndDate);
        void GetSaleByDate(DateTime Date);
        void GetSaleByAmountRange(double FirstAmount, double LastAmount);
        void GetSaleByNumber(int Number);
        void AddProduct(int Code);
        void ChangeProductNameCountAmountCategory(int Code, String Name, double Price, int Count, Category Category);
        void GetProductByCategory(int CategoryNumber);
        void GetProductByAmountRange(double MinAmount, double MaxAmount);
        void SearchProductByName(String Text);
    }
}
