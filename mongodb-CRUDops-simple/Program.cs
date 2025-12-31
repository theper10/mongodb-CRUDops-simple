using MongoDB.Driver;
using System.Threading.Tasks;

namespace mongodb_CRUDops_simple
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var connectionString = "mongodb://root:example@localhost:27017";
            var client = new MongoClient(connectionString);

            var db = client.GetDatabase("sys25d");

            var persons = db.GetCollection<Person>("persons");

            var all = await persons.Find(_ => true).ToListAsync();

            foreach (var p in all)
            {
                Console.WriteLine($"{p.Name} ({p.Age}) {p.Email} - {p.Address.City} - {p.Address.PostalCode}");
            }
        }
    }
}
