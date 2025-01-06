namespace Lesson9task3;
internal class Program
{
    static void Main(string[] args)
    {
        var dictionary = new Dictionary<string, int>();
        Console.WriteLine("Enter text:");
        var text = Console.ReadLine();
        var IsEmpty = string.IsNullOrWhiteSpace(text);
        while (IsEmpty == true)
        {
            Console.WriteLine("You haven't entered a text");
            Console.WriteLine("Enter text:");
            text = Console.ReadLine();
            IsEmpty = string.IsNullOrWhiteSpace(text);
        }
        string[] words = text.Split(' ');
        var isWordExist = false;
        foreach (var word in words)
        {
            isWordExist = dictionary.TryGetValue(word, out var count);
            if (word != "")
            {
                if (isWordExist == false)
                {
                    dictionary.Add(word, 1);
                }
                else
                {
                    dictionary[word]++;
                }
            }
        }
        foreach (var word in dictionary)
        {
            Console.WriteLine($"Word «{word.Key}» was repeated {word.Value} times");
        }
    }
}

