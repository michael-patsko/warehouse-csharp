namespace Warehouse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Item banana = new Item("Banana", 0.2M, "Groceries");
            Services.ViewItemDetails(banana);
        }
    }
}
