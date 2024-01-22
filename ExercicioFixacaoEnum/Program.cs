using ExercicioFixacaoEnum.Entities;
using ExercicioFixacaoEnum.Entities.Enums;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(name, email, birthDate);
Order order = new Order(status, client);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price ");
    double price = double.Parse(Console.ReadLine());
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product product = new Product(productName, price);
    OrderItem orderItem = new OrderItem(quantity,price,product);

    order.addItem(orderItem);
}
Console.WriteLine();
Console.WriteLine("Order Sumamry:");
Console.WriteLine(order);
    
