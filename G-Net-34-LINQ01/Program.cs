namespace G_Net_34_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Console.WriteLine("Hello, World!");
            List<Product> ProductList = ListGenerators.ProductList;

            // 1.Get all products from the "Seafood" category.Print each product's name and price.
            var seafoodproducts = ProductList.Where(p => p.category == "seafood");
            foreach(var product in seafoodproducts)
            {
                Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");

            }
            #endregion
        }
    } 