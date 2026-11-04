var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.EasyDotnetRepro_WebApi>("webapi")
    .WithHttpEndpoint()
    .WithUrlForEndpoint("http", ep =>
    {
        ep.Url = "/weatherforecast";
    });

builder.Build().Run();
