using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace DevOpsProjekt.Tests;

public class ApiTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public ApiTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task Root_ReturnsOk()
    {
        var resp = await _client.GetAsync("/");
        Assert.Equal(HttpStatusCode.OK, resp.StatusCode);
    }

    [Fact]
    public async Task Products_ReturnsOk_AndContainsKeyboard()
    {
        var resp = await _client.GetAsync("/products");
        resp.EnsureSuccessStatusCode();

        var body = await resp.Content.ReadAsStringAsync();
        Assert.Contains("Keyboard", body);
    }
}
