WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();
app.MapGet("/echo/{s:alpha}", (string s) => s);
app.Run();
