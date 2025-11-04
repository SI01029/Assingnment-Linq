
using static LINQ_Ass_1.Data.ListGenerator;
namespace Assingnment_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        { //******************LINQ - Restriction Operators************************
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

        }
    }       

}
