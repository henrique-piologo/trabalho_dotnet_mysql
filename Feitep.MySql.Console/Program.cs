
using System.Net.WebSockets;
using Feitep.MySql.Repository;

Console.ReadKey();

var factory = new SistemaContextFactory();
var context = factory.CreateDbContext();

var clientes = context.Clientes!.ToList();

clientes.ForEach(cliente =>
{
    System.Console.WriteLine($"{cliente.Id} - {cliente.Nome} - {cliente.DataNascimento}");
}
);

Console.ReadKey();