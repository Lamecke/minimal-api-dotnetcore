using MinimalApi.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "emeail@email.com" && loginDTO.Password == "123456")
    {
        return Results.Ok("Login secesso");
    }
    else
        return Results.Unauthorized();
});

app.Run();

