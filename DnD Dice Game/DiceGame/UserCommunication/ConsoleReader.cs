public static class ConsoleReader
{
    public static int ReadInteger(string message)
    {
        int result;
        do
        {
            Console.WriteLine(message);
        } while (!int.TryParse(Console.ReadLine(), out result)); //provides a static method to read an integer from the console with a message
        return result;
    }
}
