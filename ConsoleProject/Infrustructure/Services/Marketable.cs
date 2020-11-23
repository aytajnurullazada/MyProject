using System;
using System.Collections.Generic;
using System.Text;
using ConsoleProject.Infrustructure.Enums;
using ConsoleProject.Infrustructure.Interfaces;
using ConsoleProject.Infrustructure.Models;
using ConsoleProject.Infrustructure.Services;


namespace ConsoleProject.Infrustructure.Services
{
    public class Marketable : IMarketable
    {
        public List<Sales> Sales => throw new NotImplementedException();

        public List<Product> Product => throw new NotImplementedException();

        public void AddProduct(int Code)
        {
            
        }

        public void AddSale(string Name)
        {
            throw new NotImplementedException();
        }

        public void ChangeProductNameCountAmountCategory(int Code, string Name, double Price, int Count, Category Category)
        {
            throw new NotImplementedException();
        }

        public void GetProductByAmountRange(double MinAmount, double MaxAmount)
        {
            throw new NotImplementedException();
        }

        public void GetProductByCategory(int CategoryNumber)
        {
            throw new NotImplementedException();
        }

        public void GetSaleByAmountRange(double FirstAmount, double LastAmount)
        {
            throw new NotImplementedException();
        }

        public void GetSaleByDate(DateTime Date)
        {
            throw new NotImplementedException();
        }

        public void GetSaleByDateRange(DateTime StartDate, DateTime EndDate)
        {
            throw new NotImplementedException();
        }

        public void GetSaleByNumber(int Number)
        {
            throw new NotImplementedException();
        }

        public void GetTotalSale()
        {
            throw new NotImplementedException();
        }

        public void RemoveProductBySale(string Name, int Count)
        {
            throw new NotImplementedException();
        }

        public void SearchProductByName(string Text)
        {
            throw new NotImplementedException();
        }
    }
}
