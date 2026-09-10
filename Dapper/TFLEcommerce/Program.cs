using TFLEcommerce.Data;
using TFLEcommerce.Repositories;

string connectionString="Server=localhost;Port=3306;Database=tflshoppingecommerce;User ID=root;Password=password;";

var connectionFactory=new DbConnectionFactory(connectionString);
var cartRepository=new CartRepository(connectionFactory);
var cart=await cartRepository.RemoveFromCart(4,3);
Console.WriteLine(cart);