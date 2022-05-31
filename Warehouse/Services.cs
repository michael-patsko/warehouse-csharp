namespace Warehouse
{
    public class Services
    {
        public void ViewStock(Warehouse warehouse)
        {

        }

        public static void ViewItemDetails(Item item)
        {
            Console.WriteLine($"Product: {item.Name}");
            Console.WriteLine($"Price: {item.Price}");
            Console.WriteLine($"Category: {item.Category}\n");
        }
    }
}
