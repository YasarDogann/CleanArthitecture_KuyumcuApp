var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.CleanArthitecture_KuyumcuApp_WebAPI>("cleanarthitecture-kuyumcuapp-webapi");

builder.Build().Run();
