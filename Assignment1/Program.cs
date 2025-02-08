using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Products = ListGenerator.ProductList;
            var Customers = ListGenerator.CustomerList;
            // Fluent Syntax
            // 1
            //var ProductsOutOfStock = Products.Where(Product => Product.UnitsInStock == 0);
            //foreach (var Product in ProductsOutOfStock)
            //{
            //    Console.WriteLine(Product);
            //}

            //---------------
            // 2
            //var ProductsInStoreHigherThan3 = Products.Where(Product => Product.UnitsInStock != 0 && Product.UnitPrice > 3);
            //foreach (var Product in ProductsInStoreHigherThan3)
            //{
            //    Console.WriteLine(Product);
            //}


            // Query Syntax
            // 1
            //var ProductsOutOfStock = from P in Products
            //                         where P.UnitsInStock == 0
            //                         select P;

            //foreach (var Product in ProductsOutOfStock)
            //{
            //    Console.WriteLine(Product);
            //}
            // ------------
            // 2 
            //var ProductsInStoreHigherThan3 = from Product in Products
            //                         where Product.UnitsInStock != 0 && Product.UnitPrice > 3
            //                         select Product;

            //foreach (var Product in ProductsInStoreHigherThan3)
            //{
            //    Console.WriteLine(Product);
            //}


            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //string[] Result = Arr.DigitsOfArray();
            //for (int i = 0; i < Result.Length; i++)
            //{
            //    Console.WriteLine(Result[i]);
            //}

            // Return a sequence of just the names of a list of products.
            //var ListOfProductsNames = Products.Select(Product => Product.ProductName);
            //foreach (var Product in ListOfProductsNames)
            //{
            //    Console.WriteLine(Product);
            //}

            //var ListOfProductsNames = from Product in Products
            //                          select Product.ProductName;

            //foreach (var Product in ListOfProductsNames)
            //{
            //    Console.WriteLine(Product);
            //}

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Result = words.Select(word => new
            //{
            //    UpperCase = word.ToUpper(),
            //    LowerCase = word.ToLower(),
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            //var ProductsProperties = Products.Select(Product =>
            //new
            //{Product.ProductID ,
            //Product.ProductName ,
            //Price = Product.UnitPrice
            //});

            //foreach (var Product in ProductsProperties)
            //{
            //    Console.WriteLine(Product);
            //}


            //var ProductsProperties = from Product in Products
            //                         select new
            //                         {
            //                             Product.ProductID,
            //                             Product.ProductName,
            //                             Price = Product.UnitPrice
            //                         };


            //foreach (var Product in ProductsProperties)
            //{
            //    Console.WriteLine(Product);
            //}


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //List<bool> R = Arr.InPlace();

            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.WriteLine($"{Arr[i]}: {R[i]}");
            //}

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //List <(int,int)> Result = new List <(int,int)> ();
            //Result = numbersA.Pairs(numbersB);
            //foreach (var pair in Result)
            //{
            //    Console.WriteLine($"{pair.Item1} is less than {pair.Item2}");
            //}

            //var ordersBelow500 = Customers.SelectMany(customer => customer.Orders)
            //                               .Where(order => order.Total < 500);

            //foreach (var Order in ordersBelow500)
            //{
            //    Console.WriteLine(Order);
            //}

            //var ordersBelow500 = from C in Customers
            //                     from Order in C.Orders
            //                     where Order.Total < 500
            //                     select Order;

            //foreach (var Order in ordersBelow500)
            //{
            //    Console.WriteLine(Order);
            //}

            //var OrderBy1998OrLater = Customers.SelectMany(Customer => Customer.Orders).Where(Order => Order.OrderDate >= new DateTime(1998 , 1 , 1));
            //foreach (var Order in OrderBy1998OrLater)
            //{
            //    Console.WriteLine(Order);
            //}

           // var OrderBy1998OrLater = from C in Customers
           //                          from Order in C.Orders
           //                          where Order.OrderDate >= new DateTime(1998, 1, 1)
           //                          select Order;

           //foreach (var Order in OrderBy1998OrLater)
           // {
           //     Console.WriteLine(Order);
           // }

        }
    }
}
