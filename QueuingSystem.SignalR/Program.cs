using QueuingSystem.SignalR.Hubs;
using QueuingSystem.SignalR.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddSingleton<OnlineUserManager>();

var app = builder.Build();
app.MapHub<QueueHub>("/queueHub");

app.Run();