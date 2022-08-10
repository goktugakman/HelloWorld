namespace Urun
{
    internal class ProductOdev
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Hp";
            product1.ProductPrice = 15000;
            product1.ProductDiscount = 15;

            Product product2 = new Product();
            product2.ProductName = "Acer";
            product2.ProductPrice = 18000;
            product2.ProductDiscount = 10;

            Product product3 = new Product();
            product3.ProductName = "Asus";
            product3.ProductPrice = 20000;
            product3.ProductDiscount = 20;



            Product[] products = new Product[] { product1, product2, product3 };
            
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.ProductPrice + " %" + product.ProductDiscount);
            }
            
        }
    }
}



class Product
{
    public string ProductName { get; set; }
    public int ProductPrice { get; set; }
    public int ProductDiscount { get; set; }
}