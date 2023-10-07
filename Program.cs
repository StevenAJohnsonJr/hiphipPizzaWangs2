using hiphopPizzaWangs2.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using hiphipPizzaWangs2;
using System.Runtime.CompilerServices;
using hiphipPizzaWangs2.Models;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<hiphopPizzaWangs2DbContext>(builder.Configuration["hiphopPizzaWangs2DbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Users

app.MapGet("/user", (hiphopPizzaWangs2DbContext db) =>
{
    return db.Users.ToList();
});

app.MapGet("/user/{id}", (hiphopPizzaWangs2DbContext db, string id) =>
{
    var user = db.Users.Where(u => u.Id == id);
    return user;
});

//Items

app.MapGet("/item", (hiphopPizzaWangs2DbContext db) =>
{
    return db.Items.ToList();
});

app.MapGet("/item/{id}", (hiphopPizzaWangs2DbContext db, int id) =>
{
    var items= db.Items.Where(u => u.Id == id);
    return items;
});

app.MapGet("/api/ItembyOrderID/{id}", (hiphopPizzaWangs2DbContext db, int id) =>
{
    var item = db.Items.Where(s => s.OrderId == id)
    .Include(s => s.Order).ToList();
    return item;
}
);

app.MapPost("/api/item", (hiphopPizzaWangs2DbContext db, Item item) =>
{
    db.Items.Add(item);
    db.SaveChanges();
    return Results.Created($"/api/item/{item.Id}", item);
});

app.MapPut("/item/{id}", (hiphopPizzaWangs2DbContext db, int id, Item item) =>
{
    Item itemToUpdate = db.Items.FirstOrDefault(c => c.Id == id);
    if (itemToUpdate == null)
    {
        return Results.NotFound();
    }
    itemToUpdate.ItemName = item.ItemName;
    itemToUpdate.ItemDescription = item.ItemDescription;
    itemToUpdate.Id = item.Id;
    itemToUpdate.OrderId = item.OrderId;
    itemToUpdate.Price = item.Price;

    db.SaveChanges();
    return Results.Ok(item);
});

app.MapDelete("/api/item/{id}", (hiphopPizzaWangs2DbContext db, int id) =>
{
    Item item = db.Items.SingleOrDefault(item => item.Id == id);
    if (item == null)
    {
        return Results.NotFound();
    }
    db.Items.Remove(item);
    db.SaveChanges();
    return Results.NoContent();

});

//Payments

app.MapGet("/api/payment", (hiphopPizzaWangs2DbContext db) =>
{
    return db.Payments.ToList();
});

app.MapGet("/api/payment/{id}", (hiphopPizzaWangs2DbContext db, int id) =>
{
    return db.Payments.FirstOrDefault(c => c.Id == id);
});

app.MapPost("/api/payment", (hiphopPizzaWangs2DbContext db, Payment payment) =>
{
    db.Payments.Add(payment);
    db.SaveChanges();
    return Results.Ok();
});

//Orders

app.MapGet("/order", (hiphopPizzaWangs2DbContext db) =>
{
    return db.Orders.ToList();
});

app.MapGet("/api/OrdersbyID/{id}", (hiphopPizzaWangs2DbContext db, int id) =>
{
    var order = db.Orders.Where(s => s.Id == id);

    return order;
}
);

app.MapPost("api/order", async (hiphopPizzaWangs2DbContext db, Order order) =>
{
    db.Orders.Add(order);
    db.SaveChanges();
    return Results.Created($"/api/Post{order.Id}", order);
});

app.MapPut("api/Order/{id}", async (hiphopPizzaWangs2DbContext db, int id, Order order) =>
{
    Order orderToUpdate = await db.Orders.SingleOrDefaultAsync(order => order.Id == id);
    if (orderToUpdate == null)
    {
        return Results.NotFound();
    }
    orderToUpdate.Id = order.Id;
    orderToUpdate.OrderId = order.OrderId;
    orderToUpdate.CustomerName = order.CustomerName;
    orderToUpdate.OrderDate = order.OrderDate;
    orderToUpdate.OrderStatus = order.OrderStatus;
    orderToUpdate.TotalRev = order.TotalRev;
    orderToUpdate.Tip = order.Tip;
    orderToUpdate.Like = order.Like;
  
    db.SaveChanges();
    return Results.NoContent();
});

app.MapDelete("/api/order/{id}", (hiphopPizzaWangs2DbContext db, int id) =>
{
    Order order = db.Orders.SingleOrDefault(Order => Order.Id == id);
    if (order == null)
    {
        return Results.NotFound();
    }
    db.Orders.Remove(order);
    db.SaveChanges();
    return Results.NoContent();

});






app.Run();

