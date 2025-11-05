using System.Diagnostics.CodeAnalysis;
using static Assignment_01.Data.ListGenerator;
namespace Assignment_01
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
        //Note: Use ListGenerators.cs & Customers.xml

            #region LINQ - Restriction Operators

            #region 1.Find all products that are out of stock.
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0);

            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

            #region 2.Find all products that are in stock and cost more than 3.00 per unit.

            //var Result = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3m);

            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

            #region 3.Returns digits whose name is shorter than their value.
            ////                   0       1      2       3       4       5        6      7        8         9   
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where((n, i) => n.Length < i);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region 1.Sort a list of products by name

            //var Result = ProductsList.OrderBy(P => P.ProductName);

            //foreach (var product in Result)
            //    Console.WriteLine(product);

            #endregion

            #region 2.Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] wordss = { "APPLE", "apple", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = wordss.OrderBy(x => x, new CustomComparer());

            //foreach (var word in Result)
            //    Console.WriteLine(word);

            #endregion

            #region 3.Sort a list of products by units in stock from highest to lowest.

            //var Result = ProductsList.OrderByDescending(P => P.UnitsInStock);
            //foreach (var product in Result)
            //    Console.WriteLine(product);


            #endregion

            #region 4.Sort a list of digits, first by length of their name, then alphabetically by the name itself.

            //string[] Digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Digits.OrderBy(D => D.Length).ThenBy(D => D);
            //foreach (var D in Result)
            //    Console.WriteLine(D);
            #endregion

            #region 5.Sort first by-word length, then by a case-insensitive sort of the words in an array.

            //string[] wordss = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


            //var Result = wordss.OrderBy(W => W.Length).ThenBy(B => B, new CustomComparer());

            //foreach (var word in wordss)
            //    Console.WriteLine(word);

            #endregion

            #region 6.Sort a list of products, first by category, then by unit price, from highest to lowest.

            //var Result = ProductsList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);

            //foreach (var product in Result)
            //    Console.WriteLine(product);
            #endregion

            #region 7.Sort first by-word length, then by a case-insensitive descending sort of the words in an array.

            //string[] wordss = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


            //var Result = wordss.OrderBy(W => W.Length).ThenByDescending(B => B, new CustomComparer());

            //foreach (var product in Result)
            //    Console.WriteLine(product);

            #endregion

            #region 8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where(W => W[1] == 'i').Reverse();

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region 1.Return a sequence of just the names of a list of products.

            //var Result = ProductsList.Select(P => P.ProductName);

            //foreach (var product in Result)
            //    Console.WriteLine(product);

            #endregion

            #region 2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).

            //string[] wordss = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Result = wordss.Select(W => new
            //{
            //    UpperCase = W.ToUpper(),
            //    LowerCase = W.ToLower(),
            //});

            //foreach (var word in Result)
            //    Console.WriteLine(word);
            #endregion

            #region 3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var Result = ProductsList.Select(P => new
            //{
            //    P.ProductName,
            //    P.UnitsInStock,
            //    Price = P.UnitPrice,
            //});

            //foreach (var product in Result)
            //    Console.WriteLine(product);

            #endregion

            #region 4.Determine if the value of int in an array match their position in the array.

            //Result
            //Number: In - place ?
            //5 : False
            //4: False
            //1: False
            //3: True
            //9: False
            //8: False
            //6: True
            //7: True
            //2: False
            //0: False

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Select((n, i) => new
            //{
            //    Number = n,
            //    X = i == n ? "True" : "False"
            //});

            //foreach (var x in Result)
            //    Console.WriteLine(x);


            #endregion

            #region 5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //Result:
            //Pairs where a < b:
            //0 is less than 1
            //0 is less than 3
            //0 is less than 5
            //0 is less than 7
            //0 is less than 8
            //2 is less than 3
            //2 is less than 5
            //2 is less than 7
            //2 is less than 8
            //4 is less than 5
            //4 is less than 7
            //4 is less than 8
            //5 is less than 7
            //5 is less than 8
            //6 is less than 7
            //6 is less than 8

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            ////var Result = from a in numbersA
            ////             from b in numbersB
            ////             where a < b
            ////             select new {NumbaerA = a, NumbaerB = b};

            //var Result = numbersA.SelectMany(n => numbersB, (a, b) => new
            //{
            //    NumberA = a,
            //    NumbaerB = b
            //}).Where(P => P.NumberA < P.NumbaerB);

            //foreach (var item in Result)
            //    Console.WriteLine(item);



            #endregion

            #region 6.Select all orders where the order total is less than 500.00.


            //var Result = CustomersList.SelectMany(O => O.Orders).Where(O => O.Total < 500);

            //foreach (var O in Result)
            //    Console.WriteLine(O);

            #endregion


            #region 7.Select all orders where the order was made in 1998 or later.

            //var Result = CustomersList.SelectMany(O => O.Orders).Where(O => O.OrderDate.Year >= 1998);

            //foreach (var O in Result)
            //    Console.WriteLine(O);
            #endregion

            #endregion

            #region LINQ - Element Operators

            #region 1.Get first Product out of Stock

            //var Result = ProductsList.FirstOrDefault(P => P.UnitsInStock == 0);

            //Console.WriteLine(Result);

            #endregion

            #region 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var Result = ProductsList.FirstOrDefault(P => P.UnitPrice > 1000, new Product() { ProductName = "Hamada", UnitPrice = 1000 });

            //Console.WriteLine(Result?.ProductName ?? "NA");

            #endregion

            #region 3.Retrieve the second number greater than 5

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Where(n => n > 5).ElementAt(1);

            //Console.WriteLine(Result);

            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 1.Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Count(I => I % 2 == 1);
            //Console.WriteLine(Result);

            #endregion

            #region 2.Return a list of customers and how many orders each has.

            //var Result = CustomersList.Select(C => new
            //{
            //    C.CustomerName,
            //    OrderCount = C.Orders.Count(),
            //});

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 3.Return a list of categories and how many products each has

            //var Result = ProductsList.Select(P => new
            //{
            //    Category = P.Category,
            //    NumberOfProducts = ProductsList.Count(C => C.Category == P.Category)
            //}).ToHashSet();

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 4.Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Sum();

            //Console.WriteLine(Result);

            #endregion

            #region 5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var Words = File.ReadAllLines("dictionary_english.txt");

            //var Result = Words.Sum(W => W.Length);

           // Console.WriteLine(Result);


            #endregion

            #region 6.Get the total units in stock for each product category.

            //var Result = ProductsList.GroupBy(P => P.Category).Select(P => new
            //{
            //    Category = P.Key,
            //    UnitInStock = P.Sum(X => X.UnitsInStock)
            //});

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 7.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var Result = words.Min(X => X.Length);

            //Console.WriteLine(Result);


            #endregion

            #region 8.Get the cheapest price among each category's products

            //var Result = ProductsList.GroupBy(P => P.Category).Select(P => new
            //{
            //    Category = P.Key,
            //    UnitPrice = P.Min(X => X.UnitPrice)
            //});

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 9.Get the products with the cheapest price in each category(Use Let)

            //var Result = from P in ProductsList
            //             group P by P.Category into PC
            //             let cheapest = PC.Where(P => P.UnitPrice == PC.Min(P => P.UnitPrice))
            //             select cheapest;

            //foreach (var item in Result)
            //{
            //    foreach (var i in item)
            //        Console.WriteLine($"Category: {i.Category}, UnitPrice: {i.UnitPrice}, ProductName: {i.ProductName}");
            //}


            #endregion

            #region 10.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var Result = words.Max(W => W.Length);

            //Console.WriteLine(Result);


            #endregion

            #region 11.Get the most expensive price among each category's products.

            //var Result = from P in ProductsList
            //             group P by P.Category into PC
            //             let expensive = PC.Where(P => P.UnitPrice == PC.Max(P => P.UnitPrice))
            //             select expensive;

            //foreach (var item in Result)
            //{
            //    foreach (var i in item)
            //        Console.WriteLine($"Category: {i.Category}, UnitPrice: {i.UnitPrice}, ProductName: {i.ProductName}");
            //}
            #endregion

            #region 12.Get the products with the most expensive price in each category.

            //var Result = from P in ProductsList
            //             group P by P.Category into PC
            //             let expensive = PC.Where(P => P.UnitPrice == PC.Max(P => P.UnitPrice))
            //             select expensive;

            //foreach (var item in Result)
            //{
            //    foreach (var i in item)
            //        Console.WriteLine($"Category: {i.Category}, UnitPrice: {i.UnitPrice}, ProductName: {i.ProductName}");
            //}

            #endregion

            #region 13.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var Result = (int)words.Average(W => W.Length);

            //Console.WriteLine(Result);


            #endregion

            #region 14.Get the average price of each category's products.

            //var Result = ProductsList.GroupBy(C => C.Category).Select(P => new
            //{
            //    P.Key,
            //    AvgPrice = P.Average(I => I.UnitPrice)
            //});

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

            #region LINQ – Set Operators

            #region 1.Find the unique Category names from Product List

            //var Result = ProductsList.Select(P => P.Category).Distinct();

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #region 2.Produce a Sequence containing the unique first letter from both product and customer names.

            //var Result = ProductsList.Select(P => P.ProductName[0]).Union(CustomersList.Select(C => C.CustomerName[0]));

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #region 3.Create one sequence that contains the common first letter from both product and customer names.

            //var Result = ProductsList.Select(P => P.ProductName[0]).Intersect(CustomersList.Select(C => C.CustomerName[0]));

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #region 4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var Result = ProductsList.Select(P => P.ProductName[0]).Except(CustomersList.Select(C => C.CustomerName[0]));

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #region 5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var Result = ProductsList.Select(P => P.ProductName[^3..]).Concat(CustomersList.Select(C => C.CustomerName[^3..]));

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #endregion

            #region LINQ – Partitioning Operators

            #region 1.Get the first 3 orders from customers in Washington

            //var Result = CustomersList.Where(C => C.Region == "WA").SelectMany(O => O.Orders).Take(3);

            //foreach (var Order in Result)
            //    Console.WriteLine(Order);

            #endregion

            #region 2.Get all but the first 2 orders from customers in Washington.

            //var Result = CustomersList.Where(C => C.Region == "WA").SelectMany(O => O.Orders).Skip(2);

            //foreach (var Order in Result)
            //    Console.WriteLine(Order);

            #endregion

            #region 3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((n, i) => n > i);

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);


            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #region 5.Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile((n, i) => n > i);

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #endregion

            #region LINQ – Quantifiers Operators

            #region 1.Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var words = File.ReadAllLines("dictionary_english.txt");

            //var Result = words.Any(W => W.Contains("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeei"));

            //Console.WriteLine(Result);

            #endregion

            #region 2.Return a grouped list of products only for categories that have at least one product that is out of stock.

            //var Result = ProductsList.GroupBy(C => C.Category).Where(C => C.Any(P => P.UnitsInStock == 0)).Select(P => P);

            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item.Key);
            //    foreach (var P in Item)
            //        Console.WriteLine(P);
            //}

            #endregion

            #region 3.Return a grouped list of products only for categories that have all of their products in stock.

            //var Result = ProductsList.GroupBy(C => C.Category).Where(C => C.All(P => P.UnitsInStock > 0)).Select(P => P);

            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item.Key);
            //    foreach (var P in Item)
            //        Console.WriteLine(P);
            //}

        #endregion

        #endregion

        #region LINQ – Grouping Operators

        #region 1.Use group by to partition a list of numbers by their remainder when divided by 5

        //Result:
        //    Numbers With a remainder of 0 when divided by 5:
        //    0
        //    5
        //    10
        //    15
        //    Numbers With a remainder of 1 when divided by 5:
        //    1
        //    6
        //    11
        //    Numbers With a remainder of 2 when divided by 5:
        //    2
        //    7
        //    12
        //    Numbers With a remainder of 3 when divided by 5:
        //    3
        //    8
        //    13
        //    Numbers With a remainder of 4 when divided by 5:
        //    4
        //    9
        //    14

        //    List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        //    var Result = numbers.GroupBy(n => n % 5);

        //    foreach (var Item in Result)
        //    {
        //        Console.WriteLine($"Numbers With a remainder of {Item.Key} when divided by 5");
        //        foreach (var n in Item)
        //            Console.WriteLine(n);
        //    }

            #endregion

            #region 2.Uses group by to partition a list of words by their first letter(Use dictionary_english.txt for Input).

            //string[] Lines = File.ReadAllLines("dictionary_english.txt");

            //var Result = Lines.GroupBy(W => W[0]);

            //foreach (var Item in Result)
            //{

            //    Console.WriteLine(Item.Key);
            //    foreach (var n in Item)
            //        Console.WriteLine(n);
            //}



            #endregion

            #region 3.Consider this Array as an Input

            //Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //Result:
            //from
            //form
            //....
            //salt
            //last
            //....earn
            //near....string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " }
            //;

            //var Result = Arr.GroupBy(W => W.Trim(), new EqualityComparer());

            //foreach (var item in Result)
            //{
            //    foreach (var i in item)
            //        Console.WriteLine(i);
            //}


            #endregion

            #endregion
        }
    }
}
