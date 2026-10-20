namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            var allProducts = Source.ProductList.Where(p => p.Category =="Seafood");
            foreach (var product in allProducts)
            {
                Console.WriteLine($"Product: {product.ProductName} , Price: {product.UnitPrice}");
            }

            #endregion
        }
    }
}
