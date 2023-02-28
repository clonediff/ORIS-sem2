using Burgers;

var builder = new BurgerBuilderImpl();

builder.AddBottomBun();
builder.AddMiddleBun();
builder.AddTopBun();
builder.Pack();
builder.Fry();

Console.WriteLine("\n\nBurger:");
Console.WriteLine(builder.GetBurger());