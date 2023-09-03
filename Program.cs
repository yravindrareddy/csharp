internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string inp = Console.ReadLine();    
        var op = RemoveDuplicates(inp);
        Console.WriteLine(op);
    }

    public static string RemoveDuplicates(string str)
    {
        List<char> op = new List<char>();
        foreach (var ch in str)
        {
            if (!op.Contains(ch))
            {
                op.Add(ch);
            }
        }
        return new string(op.ToArray());
    }
}