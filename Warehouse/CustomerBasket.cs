namespace Warehouse
{
    public class CustomerBasket
    {
        Dictionary<Item, int> contents;
        decimal totalCost;
        void RemoveItem(Item item)
        {
            contents.Add(item, -1);
            totalCost -= item.Price;
            // Tidy up for negative values
        }
        void AddItem(Item item)
        {
            contents.Add(item, 1);
            totalCost += item.Price;
        }
        void Buy()
        {

        }
    }
}
