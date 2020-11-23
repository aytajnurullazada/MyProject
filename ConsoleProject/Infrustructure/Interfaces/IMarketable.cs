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
        void AddSale(Sales sale);
        void RemoveProductBySale(string Name, int Count);
        void GetTotalSale();
        List<Sales> GetSaleByDateRange(DateTime StartDate, DateTime EndDate);
        void GetSaleByDate(DateTime Date);
        void GetSaleByAmountRange(double FirstAmount, double LastAmount);
        void GetSaleByNumber(int Number);
        void AddProduct(Product product);
        void ChangeProduct(string Code);
        List<Product> GetProductByCategory(Category CategoryNumber);
        List<Product> GetProductByAmountRange(double MinAmount, double MaxAmount);
        void SearchProductByName(String Text);
    }
}
