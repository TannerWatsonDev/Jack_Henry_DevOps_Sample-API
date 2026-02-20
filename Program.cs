
// prepares configuration/services/logging and defaults
var builder = WebApplication.CreateBuilder(args);
// Builds the web application using the configured services and settings
var app = builder.Build();

//Defines/Maps an HTTP GET request to the / endpoint and returns a string when that endpoint is requested.
app.MapGet("/", () => "Jack Henry DevOps Sample API");
//Defines/Maps an HTTP GET request to the /health endpoint and returns a string then return healthy string whenr requested.
app.MapGet("/health", () => Results.Ok("Healthy"));

app.Run();

