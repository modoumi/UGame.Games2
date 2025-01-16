using TinyFx;

var builder = AspNetHost.CreateBuilder();

// ע��TinyFx��GameServer
builder.AddAspNetEx();
//builder.Host.UseApiGameServer<Dwin_poker.BLL.GameSection, Dwin_poker.BLL.GameServer>();
//builder.Host.UseApiGameServer<Super_phoenix.BLL.GameSection, Super_phoenix.BLL.GameServer>();
//builder.Host.UseApiGameServer<GameSection, GameServer>();

var app = builder.Build();
// ����TinyFx
app.UseAspNetEx();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
