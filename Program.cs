internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Lütfen aralarına virgül koyarak bir kelime ve bir index giriniz: ");
        string input = Console.ReadLine();
        string[] inputs = input.Split(",");
        string word = inputs[0];
        int index = Convert.ToInt32(inputs[1]);
        Console.WriteLine(word[index]);
    }
}