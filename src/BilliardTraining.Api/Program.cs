var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => new { name = "Billiard Training API" });

app.Run();
