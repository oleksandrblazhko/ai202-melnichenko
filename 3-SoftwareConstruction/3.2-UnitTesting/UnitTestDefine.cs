namespace DataAccess.Test;

public static class UnitTest
{
    
    public static async void LoginTest(string test_receiver, string test_MessageText)
    {
        LoginDataServices LoginDatabase = new LoginDataServices();

        //Code: -1
        //Перевірка чи є одержувач
        Console.WriteLine("TC1.1");
        if (await LoginDatabase.LoginIn(test_receiver, test_receiver) == -1)
            Console.WriteLine("\tPassed");
        else
            Console.WriteLine("\tFailed");

        //Code: -2
        //Перевірка тексту листа
        Console.WriteLine("TC1.2");
        if (await LoginDatabase.LoginIn(test_MessageText, test_MessageText) == -2)
            Console.WriteLine("\tPassed");
        else
            Console.WriteLine("\tFailed");
    }

}