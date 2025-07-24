
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;

namespace WebApi.Tests;

public class HelloControllerTests
{
    [Fact]
    public void Get_Returns_Hola()
    {
        var controller = new HelloController();

        var result = controller.Get() as OkObjectResult;

        Assert.NotNull(result);
        Assert.Equal("Hola desde la API", result.Value);
    }
}
