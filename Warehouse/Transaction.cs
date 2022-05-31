namespace Warehouse
{
    public class Transaction
    {
        Dictionary<Item, int> items;
        DateTime dateTime;
        Account from;
        Account to;
        string modeOfPayment;
    }
}
