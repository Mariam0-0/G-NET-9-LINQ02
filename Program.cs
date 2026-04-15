using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System;
using LINQ.DataSources;
using LINQ.Helpers;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace G_NET_9_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //==============================================
            //1.Get top 3 most expensive products
            //==============================================

            //var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 02
            //==============================================
            //2.show page 2 of products, with page size = 5
            //==============================================

            //var page1 = Source.ProductList.Take(5);
            //var page2 = Source.ProductList.Skip(5).Take(5);
            //Console.WriteLine("=== Page 1 ====");
            //foreach (var item in page1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Console.WriteLine("=== Page 2 ====");
            //foreach (var item in page2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 03
            //==============================================
            //3.Take products from the list as long as Their UnitPrice is less than
            //$25(list is ordered by price).
            //==============================================

            //// order first then get result
            //var result = Source.ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 04
            //==============================================
            //4.Check if ALL products in the "Seafood" category are in stock
            //==============================================

            //var result = Source.ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            //Console.WriteLine(result);
            #endregion

            #region Question 05
            //==============================================
            //5.Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };
            //==============================================

            //// both give the same result
            //int[] ids = { 3, 9, 13, 18 };

            //var result = ids.Any(x => x == 9);
            //Console.WriteLine(result);

            //result = ids.Contains(9);
            //Console.WriteLine(result);

            #endregion

            #region Question 06
            //==============================================
            //6.Group all products by Category and print each group with its
            //product count.
            //==============================================

            //var result = Source.ProductList.GroupBy(p => p.Category);
            //foreach (var group in result)
            //{
            //    int count = group.Count();
            //    Console.WriteLine($"Category: {group.Key} - Count: {count}");

            //}
            #endregion

            #region Question 07
            //==============================================
            //7.Group products by Category and project only product names per
            //group
            //==============================================

            //var result = Source.ProductList.GroupBy(p => p.Category);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach(var item in group) Console.WriteLine(item.ProductName);
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            #endregion

            #region Question 08
            //==============================================
            //8.Find all categories that have MORE THAN 3 products
            //==============================================

            //var result = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Count() > 3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key} - Count: {item.Count()}");
            //}

            #endregion

            #region Question 09
            //==============================================
            //9.Using QUERY SYNTAX, group customers by Country, and for each
            //group select { Country, Count, TotalOrderValue }.
            //==============================================

            //var result = from c in Source.CustomerList
            //             group c by c.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //             };
            //foreach(var c in result)
            //{
            //    Console.WriteLine($"Country: {c.Country}, Customers: {c.Count}, Total Orders Value: {c.TotalOrderValue:C}");
            //}


            #endregion

            #region Question 10
            //==============================================
            //10.Calculate the total number of units in stock across all products
            //==============================================

            //var result = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(result);
            #endregion

            #region Question 11
            //==============================================
            //11.Find the CHEAPEST and MOST EXPENSIVE product prices
            //==============================================

            //var cheapest = Source.ProductList.Min(p => p.UnitPrice);
            //var expensive = Source.ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine($"Cheapest: {cheapest}");
            //Console.WriteLine($"Most expensive: {expensive}");
            #endregion

            #region Question 12
            //==============================================
            //12.Get a distinct list of all product categories
            //==============================================

            //var result = Source.ProductList.Select(p => p.Category).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 13
            //==============================================
            //13.find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //==============================================

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);
            //foreach(int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Question 14
            //==============================================
            //14.Find countries that appear in list1 but NOT in list2
            //(case -insensitive).
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //==============================================

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2, new StringCaseInsensitiveComparer());
            //foreach ( var item in result )
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 15
            //==============================================
            //15.Build a Dictionary<int, Product> keyed by ProductID. Then
            //retrieve and print the product with ID = 18.
            //==============================================

            //var result = Source.ProductList.ToDictionary(p => p.ProductID);
            //Console.WriteLine(result[18]);
            #endregion

            #region Question 16
            //==============================================
            //16.Get the first product whose price is greater than $50.
            //==============================================

            //var result = Source.ProductList.First(p => p.UnitPrice > 50);
            //Console.WriteLine(result);
            #endregion

            #region Question 17
            //==============================================
            //17.Try to get the first product with a price > $500.
            //it returns null
            //instead of throwing.
            //==============================================

            //var result = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 500, null);
            //Console.WriteLine(result != null? result.ProductName : "not found");

            #endregion

            #region Question 18
            //==============================================
            //18.Generate a multiplication table row for 7
            //==============================================

            //
            //var result = Enumerable.Range(0, 13)
            //    .Select(n => new
            //    {
            //        Number = n,
            //        Result = 7* n
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"7 x {item.Number} = {item.Result}");
            //}
            #endregion

            #region Question 19
            //==============================================
            //19.Generate even numbers between 1 and 30.
            //==============================================

            //var result = Enumerable.Range(1, 30).Where(n => n % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 20
            //==============================================
            //20.Concatenate the first 3 product names with the first 3
            //customer company names into a single sequence.
            //==============================================

            //var result = Source.ProductList.Select(p => p.ProductName).Take(3)
            //                                .Concat(Source.CustomerList.Select(c => c.CompanyName).Take(3));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            
            #endregion

            #region Question 21
            //==============================================
            //21.Pair each product with a customer(by position) and produce
            //a string "ProductName sold to CompanyName".
            //==============================================

            #endregion
        }
    }
}
