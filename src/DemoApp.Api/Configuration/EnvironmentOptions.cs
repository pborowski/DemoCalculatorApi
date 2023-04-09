namespace DemoApp.Api.Configuration;

public sealed class EnvironmentOptions
{
    public const string SectionName = "Environment";
    public string Name { get; set; } = String.Empty;
}