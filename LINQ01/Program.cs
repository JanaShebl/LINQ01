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
        }
    }
}
