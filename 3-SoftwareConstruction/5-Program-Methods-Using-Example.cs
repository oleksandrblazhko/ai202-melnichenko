using ConsoleApp1.DataAccsess;
using ConsoleApp1.Models;

SendMessage db = new SendMessage();

User newData = new User()
{
    LastName = "Herringhton",
    FirstName = "Billy"
   
};
await db.Create(newData);
var list = await db.GetAll();

foreach (var item in list)
{
    Console.WriteLine(item);
}

//Code -1
Message MessageData = new Message()
{
    sender = newData,
    receiver = newData,
    message = "without frezzer iteruption lets celebraite and ..." 

};
var number = await db.SendMes(MessageData);

Console.WriteLine(MessageData);

User newData2 = new User()
{
    Id=0,
    LastName = "Rambo",
    FirstName = "Jhon"

};

Message MessageData2 = new Message()
{
    sender = newData,
    receiver = newData,
    message = null 

};
var number2 = await db.SendMes(MessageData2);

Console.WriteLine(MessageData2);

