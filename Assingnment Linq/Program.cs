
using Assingnment_Linq.Data;
using static LINQ_Ass_1.Data.ListGenerator;
namespace Assingnment_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            Console.WriteLine("******************LINQ - Restriction Operators************************");
            ////1.Find all products that are out of stock.
            //Method syntax [fluent]
            var ProductsOutOfStock1 = ProductList?.Where(P => P.UnitsInStock == 0);
            //Query syntax 
            var ProductsOutOfStock2 = from p in ProductList
                                      where p.UnitsInStock == 0
                                      select p;

            foreach (var product in ProductsOutOfStock1 ?? Enumerable.Empty<object>()) Console.WriteLine(product);

            Console.WriteLine("*****************************");

            ////2.Find all products that are in stock and cost more than 3.00 per unit.
            //Method syntax [fluent]
            var ProductsInStock1 = ProductList?.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00m);
            //Query syntax
            var ProductsInStock2 = from p in ProductList
                                   where p.UnitsInStock > 0 && p.UnitPrice > 3.00m
                                   select p;

            foreach (var product in ProductsInStock1 ?? Enumerable.Empty<object>()) Console.WriteLine(product);
            Console.WriteLine("*****************************");
            //3.Returns digits whose name is shorter than their value.
            String[] Arr1 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //Method syntax 
            var result = Arr1.Where((E, I) => E.Length < I);
            foreach (var number in result) Console.WriteLine(number);
            Console.WriteLine("*****************************");

            # endregion

            #region LINQ - Element Operators

            // 1.Get first Product out of Stock

            var Result =ProductList.FirstOrDefault(P => P.UnitsInStock == 0);

            Console.WriteLine(Result);

           

            // 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            var Result1 = ProductList.FirstOrDefault(P => P.UnitPrice > 1000, new Product() { ProductName = "Hamada", UnitPrice = 1000 });

            Console.WriteLine(Result1?.ProductName ?? "NA");

          

           //3.Retrieve the second number greater than 5

            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var Result2 = Arr.Where(n => n > 5).ElementAt(1);

            Console.WriteLine(Result2);

            
            #endregion

        }
    }

}
