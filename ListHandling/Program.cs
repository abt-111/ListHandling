internal class Program
{
    private static void Main(string[] args)
    {
        List<String> listOfString = new List<String>();

        listOfString.Add("Bonjour");
        listOfString.Add(" le");
        listOfString.Add(" monde");
        DisplayListOfString(listOfString);

        listOfString.RemoveAt(0);
        DisplayListOfString(listOfString);

        listOfString.Remove(" monde");
        DisplayListOfString(listOfString);

        listOfString[0] = "Bonjour le monde";
        DisplayListOfString(listOfString);
    }

    public static void DisplayListOfString(List<String> listOfString)
    {
        int index = 0;

        foreach (string s in listOfString)
        {
            Console.WriteLine($"listOfString[{index}] : {s}");
            index++;
        }
        Console.WriteLine();
    }
}