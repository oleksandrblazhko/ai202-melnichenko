using ConsoleApp1.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataAccsess;

public class SendMessage
{
    private readonly IMongoCollection<User> _User;
    private const string Connection =
        "mongodb+srv://GachiClub:ASSWECAN@cluster0.xeevpri.mongodb.net/?retryWrites=true&w=majority";

    private const string DatabaseName =
        "application_db";


    public SendMessage()
    {
        var mongoClient = new MongoClient(Connection);

        _User = mongoClient
            .GetDatabase(DatabaseName)
            .GetCollection<User>("user_data");
    }

    public async Task Create(User newUserData) =>
        await _User.InsertOneAsync(newUserData);

    public async Task<List<User>> GetAll() =>
        await _User.Find(_ => true).ToListAsync();

    public async Task<int> SendMes(Message message)
    {

        if (message.receiver.Id <= 0||message.sender.Id <=0)
            return -1;

        if (message.message.Length < 1 || message.message.Length > 1024)
        {
            return -2;
        }

        User userDataInDatabase;
        try
        {
            userDataInDatabase =
                       await _User.Find(c => c.Id == message.receiver.Id).FirstAsync();

        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
            Console.WriteLine($"Користувача {message.receiver.Id} не iснує!");
            return -3;
        }
        return 0;
    }

}
