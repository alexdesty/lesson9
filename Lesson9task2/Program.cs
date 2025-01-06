namespace Lesson9task2;

internal class Program
{
    static void Main(string[] args)
    {
        ProductRegistry.productDictionary.Add("Milk", 1.8);
        ProductRegistry.productDictionary.Add("Bread", 1.3);
        ProductRegistry.productDictionary.Add("Cheese", 4.8);
        ProductRegistry.ShowProducts();
        Console.WriteLine("Enter product to search: ");
        ProductRegistry.SearchProduct(Console.ReadLine());
        ProductRegistry.IncreaseByTenPersentAndShow();
        ProductRegistry.ShowProducts();
    }
}
