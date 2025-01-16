using BestShooter.BLL;
using TinyFx;

var builder = AspNetHost.CreateBuilder();

// Add services to the container.
builder.AddAspNetEx();
builder.Host.UseBestShooterServer();
builder.Host.UseApiGameServer<GameSection, GameServer>();

var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseAspNetEx();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();

