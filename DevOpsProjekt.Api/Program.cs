var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { status = "ok", service = "DevOpsProjekt.Api" }));

app.MapGet("/products", () =>
{
    var products = new[]
    {
        new { id = 1, name = "Keyboard", price = 199.99 },
        new { id = 2, name = "Mouse", price = 99.99 },
        new { id = 3, name = "Monitor", price = 899.00 }
    };

    return Results.Ok(products);
});

app.Run();

// potrzebne, ¿eby testy mog³y wystartowaæ aplikacjê
public partial class Program { }
