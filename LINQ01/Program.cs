namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //var allProducts = Source.ProductList.Where(p => p.Category =="Seafood");
            //foreach (var product in allProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName} , Price: {product.UnitPrice}"); 
            //}

            #endregion

            #region Q2

            //var products = Source.ProductList;
            //foreach(var p in products)
            //{
            //    Console.WriteLine($"Product: {p.ProductName}");
            //}

            #endregion

            #region Q3

            //var sotredProducts = Source.ProductList.OrderByDescending(p => p.UnitPrice);
            //foreach (var p in sotredProducts)
            //{
            //    Console.WriteLine($"Product: {p.ProductName} , Price: {p.UnitPrice}");
            //}

            #endregion

            #region Q4

            //var result = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            //foreach (var p in result)
            //{
            //    Console.WriteLine($"Product: {p.ProductName} , Price: {p.UnitPrice}");
            //}

            #endregion

            #region Q5

            //var result = Source.ProductList.Where(p=>p.UnitsInStock>0 && p.Category== "Condiments");
            //foreach (var p in result)
            //{
            //    Console.WriteLine($"Product: {p.ProductName} , Stock: {p.UnitsInStock}");
            //}

            #endregion

            #region Q6

            //var result = Source.ProductList.Select(p => new {p.ProductName, p.UnitPrice ,status=p.UnitsInStock>0?"Available":"Out of Stock"});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product: {item.ProductName} , Price: {item.UnitPrice} , Status: {item.status}");
            //}

            #endregion

            #region Q7

            //var result = Source.ProductList.Select((p,i)=>$"{i+1}-{p.ProductName}");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q8

            //var result = Source.ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var p in result)
            //{
            //    Console.WriteLine($"Product: {p.ProductName} , Category: {p.Category} , Price: {p.UnitPrice}");
            //}

            #endregion

            #region Q9

            //var result = Source.ProductList.Where(p=>p.Category=="Beverages").OrderByDescending(p => p.UnitsInStock);
            //foreach (var p in result)
            //{
            //    Console.WriteLine($"Product: {p.ProductName} , Stock: {p.UnitsInStock}");
            //}

            #endregion

            #region Q10

            //var result = from c in Source.CustomerList
            //             from o in c.Orders
            //             where o.OrderDate > new DateTime(1997, 1, 1)
            //             select new { c.CustomerID, o.OrderDate };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Customer: {item.CustomerID} , Order Date: {item.OrderDate:d}");
            //}

            #endregion
        }
    }
}
