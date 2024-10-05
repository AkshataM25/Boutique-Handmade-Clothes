namespace Product
{
    //Creating Product Class
    public class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        
        //No argument constructor
        public Product()
        {

        }
        
        //Parametersized constructor
        public Product(string name, int stock)
        {
            Name = name;
            Stock = stock;
        }


    }

    public class DeliveryService
    {
        public void PlaceOrder(Product product)
        {
            if (product.Stock <=0)
            {
                throw new Exception("Product is out of stock");
            }

            Console.WriteLine("Order Placed Successfully");
            product.Stock--;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Taking input from user
            Console.WriteLine("Enter the product name");
            string pn = Console.ReadLine();
            Console.WriteLine("Enter the number of Stocks");
            int st = int.Parse(Console.ReadLine());

            Product product = new Product(pn,st);
            DeliveryService deliveryService = new DeliveryService();

            try
            {
                deliveryService.PlaceOrder(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Product is out of stock");
            }
            finally
            {
                
            }
        }
    }
}