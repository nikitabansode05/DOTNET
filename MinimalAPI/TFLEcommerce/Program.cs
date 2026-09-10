using TFLEcommerce.Data;
using TFLEcommerce.Models;
using TFLEcommerce.Repositories;

var builder=WebApplication.CreateBuilder(args);

var connectionString="Server=localhost;Port=3306;Database=tflshoppingecommerce;User Id=root;Password=password;";

builder.Services.AddSingleton(new DbConnectionFactory(connectionString));

builder.Services.AddScoped<CartRepository>();

var app = builder.Build();

app.MapPut("/api/cart/delete",async(
    DeleteFromCart deleteProd,
    CartRepository cartRepo)=>
{
    var result=await cartRepo.RemoveFromCart(deleteProd.productId,deleteProd.userId);
    return Results.Ok(new{message="Product deleted",rowsAffected=result});
});

app.Run();