nternal class Program
{
    private static void Main(string[] args)
    {
        LoginDataServices db = new LoginDataServices();


        string sender = new string('t', 40);
        string receiver = new string('t', 40);
        Console.WriteLine($"\nsender: {sender}; receiver: {receiver}");
        UnitTest.LoginTest(sender, receiver);

        sender = "Billy Herringhton";
        receiver = null;

        Console.WriteLine($"\nsender: {sender}; receiver: {receiver}");
        UnitTest.LoginTest(login, receiver);

        sender = "Billy Herringhton";
        receiver = "Jhon Rambo ";

        Console.WriteLine($"\nsender: {sender}; receiver: {receiver}");
        UnitTest.LoginTest(sender, receiver);
    }
}