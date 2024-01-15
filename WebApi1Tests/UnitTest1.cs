using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using WebApi1.Controllers;
using Assert = Xunit.Assert;

namespace WebApi1Tests;

public class Tests
{
    private readonly ScooterController _scooterController = new  ();
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Can_Get_A_Code_For_A_Scooter()
    {
        var result = _scooterController.Get();
        
        Assert.IsType<OkObjectResult>(result);
        var resultObject = (ObjectResult) result;

        Assert.IsType<Guid>(resultObject.Value);
    }
}