using NoobGGApp.Domain.Common.Entities;
using NoobGGApp.Domain.ValueObjects;

namespace NoobGGApp.Domain.Entities;

public sealed class Game : EntityBase<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }


    public Game()
    {
        Email userEmail = new Email("merveeksii61@gmail.com");

        string email = userEmail;

        Customer customer1 = new Customer("merveeksii61@gmail.com");

        customer1.Address.City = "İstanbul";

        Customer customer2 = new Customer("merveeksii61@gmail.com");

        if (customer1.Address == customer2.Address)
        {

        }
    }
}