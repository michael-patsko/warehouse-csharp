namespace Warehouse
{
    public class Warehouse
    {
        Dictionary<Item, int> stock;
        Account account;
        List<Transaction> transactions;
        void SellItem(Item item, Account buyer)
        {

        }
        void BuyItem(Item item, Account seller)
        {

        }
        bool HasStock(Item item)
        {
            return stock[item] > 0;
        }
    }
}
