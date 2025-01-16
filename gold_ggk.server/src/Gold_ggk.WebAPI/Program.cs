using Gold_ggk.BLL;
using TinyFx;

var builder = AspNetHost.CreateBuilder(args);

// ◊¢≤·TinyFx∫ÕGameServer
builder.AddAspNetEx(AspNetType.Api);
builder.Host.UseApiGameServer<GameSection, GameServer>();

var app = builder.Build();
// ∆Ù”√TinyFx
app.UseAspNetEx();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
