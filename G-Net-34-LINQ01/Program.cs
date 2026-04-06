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
            foreach (var product in seafoodproducts)
            {
                Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");

            }
            #endregion

            #region 2
            //2. Get a list of only the product names from ProductList. Printeach name.

            var productnames = ProductList.Select(ProductList => ProductList.productName);
            foreach (var name in productnames)
            {
                Console.WriteLine(name);
            }

            #endregion

            #region 3

            //3. Sort all products by UnitPrice (ascending). Print eachproduct's name and price.
            var sortedproducts = ProductList.OrderBy(p => p.unitPrice);
            foreach (var product in sortedproducts)
            {
                Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            }

            #endregion
        }
    }
    } 