var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.NetAspireSample_Web>("netaspiresample-web");

builder.Build().Run();
