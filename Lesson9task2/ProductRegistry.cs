namespace Lesson9task2;

internal static class ProductRegistry
{
    public static Dictionary<string, double> productDictionary = new Dictionary<string, double>();

    public static void ShowProducts()
    {
        Console.WriteLine("List of products: ");
        foreach (var product in productDictionary)
        {
            Console.WriteLine($"Product name: {product.Key}, price: {Math.Round(product.Value,2)}");
        }
    }

    public static void IncreaseByTenPersentAndShow()
    {
        Console.WriteLine("Increase product prices by 10%:");
        foreach (var product in productDictionary)
        {
            productDictionary[product.Key] = product.Value * 1.1;
        }
    }

    public static void SearchProduct(string productNameToSearch)
    {
        var IsEmpty = string.IsNullOrWhiteSpace(productNameToSearch);
        while (IsEmpty == true)
        {
            Console.WriteLine("You have not entered a product name");
            Console.WriteLine("Enter product to search:");
            productNameToSearch = Console.ReadLine();
            IsEmpty = string.IsNullOrWhiteSpace(productNameToSearch);
        }
        var isFound = false;
        foreach (var product in productDictionary)
        {
            if (product.Key.ToLower() == productNameToSearch)
            {
                Console.WriteLine($"Product name to search: {product.Key}, product price: {Math.Round(product.Value, 2)}");
                isFound = true;
            }
        }
        if (isFound == false)
        {
            Console.WriteLine($"Product «{productNameToSearch}» not found");
        }
    }
}

