var builder = DistributedApplication.CreateBuilder(args);

// Frontend
builder.AddNpmApp("react", "../Web/ClientApp", scriptName: "dev")
    .WithEnvironment("BROWSER", "none")
    .WithHttpEndpoint(env: "VITE_PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();

builder.Build().Run();
