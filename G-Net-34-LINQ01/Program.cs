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
            #region 4
            //4. Get all products where UnitPrice is between 10 and 30
            var pr30 = ProductList.Where(p => p.unitprice >= 10 && p.unitprice <= 30);
            foreach (var product in pr30)
            {
                Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            }

            #endregion
            #region q5
            //5. Get all products that are in stock (UnitsInStock > 0) anbelong to the "Condiments" category.

            var condiments = ProductList.Where(p => p.unitsinstock > 0 && p.catagory == "condiments");
            foreach (var product in condiments)
            {
                Console.WriteLine($"Name: {product.ProductName}, Stock: {product.UnitsInStock}, Price: {product.UnitPrice}");
            }
            #endregion
            #region q6
            var prstatus = ProductList.Select(p => new
            {
                name = p.name,
                price = p.price
            ,
                StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            });
            foreach (var item in prstatus)
            {
                Console.WriteLine($"Name: {item.name}, Price: {item.price}, Status: {item.StockStatus}");
            }
            #endregion

            #region q7
            //7. Print each product's name along with its position (1-based)in the list. Expected format: 1.Chai, 2.Chang, etc.
            var index = ProductList.Select((p, index) => new
            {
                position = index + 1,
                name =p.name
            });
            foreach (var item in index)
            {
                Console.WriteLine($"{item.position}. {item.name}");
            }

            #endregion
        }
    }
    } 