using DemoApp.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();

var environmentOptions = new EnvironmentOptions();
builder.Configuration.GetSection(EnvironmentOptions.SectionName).Bind(environmentOptions);

var app = builder.Build();

if (ShouldDisplaySwagger(environmentOptions.Name))
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapHealthChecks("/health");
app.MapGet("/", () => "DemoApp.Api works!");
app.Run();

bool ShouldDisplaySwagger(string environmentName)
{
    var allowedEnvironments = new[] { "local", "dev" };
    return allowedEnvironments.Contains(environmentName);
}