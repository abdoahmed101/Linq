using Assignment1;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Products = ListGenerator.ProductList;
            var Customers = ListGenerator.CustomerList;

            //var FirstElementOutOfStock = Products.First(P => P.UnitsInStock == 0);
            //Console.WriteLine(FirstElementOutOfStock);


            //var FirstElementWithPriceAbove1000 = Products.FirstOrDefault(P => P?.UnitPrice > 1000 , null);


            //int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var TheSecondNumberGreaterThan5 = Arr.Where(A => A > 5).Skip(1).First();
            //Console.WriteLine(TheSecondNumberGreaterThan5);


            //int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var countOfOddNumbers = Arr.Where(A => A % 2 != 0).Count();
            //Console.WriteLine(countOfOddNumbers);


            //var CustomerListWithOredersCount = Customers.Select(C => new 
            //{
            //    C,  
            //    OrderCount = C.Orders.Length
            //});


            //var CustomerListWithOredersCount = from C in Customers
            //                                   select new { C, OrderCount = C.Orders.Length };


            //foreach (var Customer in CustomerListWithOredersCount)
            //{
            //    Console.WriteLine($"{Customer}");
            //}


            //var CategoriesAndNumberOfProducts = Products.GroupBy(P => P.Category).Select(p => new {CategoryName = p.Key , ProductCount = p.Count()});

            //foreach (var Category in CategoriesAndNumberOfProducts)
            //{
            //    Console.WriteLine($"{Category.CategoryName} , {Category.ProductCount}");
            //}


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var TotalNumber = Arr.Sum();
            //Console.WriteLine(TotalNumber);


            string filePath = "dictionary_english.txt";
            string [] lines = File.ReadAllLines(filePath);


            //var TotalNumOfChars = lines.Select(l => l.Length);
            //foreach (var line in TotalNumOfChars)
            //{
            //    Console.WriteLine(line);
            //}

            //var LengthOfShortestWord = lines.Select(l => l.Length).Min();
            //Console.WriteLine(LengthOfShortestWord);

            //var LengthOfLongestWord = lines.Select(l => l.Length).Max();
            //Console.WriteLine(LengthOfLongestWord);

            //var AvgLengthOfTheWords = lines.Select(l => l.Length).Average();
            //Console.WriteLine(AvgLengthOfTheWords);

            //var UniqueCategories = Products.Select(p => p.Category).Distinct();
            //foreach (var category in UniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}

            //var UniqueFirstLetterProductAndCustomers = Products.Select(p => p.ProductName.First()).Union(Customers.Select(C => C.CustomerName.First()).Distinct());
            //foreach (var unique in UniqueFirstLetterProductAndCustomers)
            //{
            //    Console.WriteLine(unique);
            //}

            //var CommonFirstLetterProductAndCustomers = Products.Select(p => p.ProductName.First()).Intersect(Customers.Select(C => C.CustomerName.First()));

            //foreach (var First in CommonFirstLetterProductAndCustomers)
            //{
            //    Console.WriteLine(First);
            //}

            //var FirstLettersInProductAndNotInCustomers = Products.Select(p => p.ProductName.First()).Except(Customers.Select(C => C.CustomerName.First()));
            //foreach (var First in FirstLettersInProductAndNotInCustomers)
            //{
            //    Console.WriteLine(First);
            //}

            //var LastThreeLettersInCustomersAndProducts = Products.Select(p => p.ProductName.Substring(p.ProductName.Length - 3)).Union(Customers.Select(C => C.CustomerName.Substring(C.CustomerName.Length - 3)));

            //foreach(var chars in LastThreeLettersInCustomersAndProducts)
            //{
            //    Console.WriteLine(chars);
            //}


        }
    }
}
