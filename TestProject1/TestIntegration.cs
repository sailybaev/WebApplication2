using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1;

public class TestIntegration
{
    [Fact]
    public void Test3()
    {
        var app = new WebApplicationFactory<Program>();
        var client = app.CreateClient();
        
        var response = client.GetAsync("/Weather?city=Astana");
        
        Assert.False(response.IsCompleted);
    }
}