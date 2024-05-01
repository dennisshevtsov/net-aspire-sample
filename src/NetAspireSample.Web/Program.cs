WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
WebApplication app = builder.Build();

app.MapDefaultEndpoints();
app.MapGet("/echo/{s:alpha}", (string s) => s);
app.Run();
