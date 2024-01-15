using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using WebApi1.Controllers;
using Assert = Xunit.Assert;

namespace WebApi1Tests;

public class Tests
{
    private Controller1 svc_controller;
    
    [SetUp]
    public void Setup()
    {
        svc_controller = new Controller1();
    }

    [Test]
    public void Test1()
    {
        var result = svc_controller.Get();
        
        Assert.IsType<OkObjectResult>(result);
        var resultObject = (ObjectResult) result;
        resultObject.Value.Should().Be("Hello!");
    }
}