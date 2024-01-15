using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using WebApi1.Controllers;
using Assert = Xunit.Assert;

namespace WebApi1Tests;

public class Tests
{
    private readonly Controller1 _svcController = new  ();
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var result = _svcController.Get();
        
        Assert.IsType<OkObjectResult>(result);
        var resultObject = (ObjectResult) result;
        resultObject.Value.Should().Be("Hello!");
    }
}