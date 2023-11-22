class Program
{
    static void Main(string[] args)
    {
        string[] questions = { "När grundades Sverige?", "När startades andra världskriget?", "När dog Gustav Vasa?", "När föddes Malte Elwhagen?" };
        string[] answers = { "6/7-1523", "01/9-1939", "29/9-1560", "18/01-2006", };
        int number = 1;


        Console.WriteLine("Vilken fråga vill du svara på?");
        foreach (var element in questions)
        {
            Console.WriteLine($"{number}. {element}");
            number++;
        }
        try
        {
            int questionInput = Convert.ToInt32(Console.ReadLine());


        }
        catch
        {
            Console.WriteLine("Du måste välja en GILTIG fråga!");
        }
    }
}