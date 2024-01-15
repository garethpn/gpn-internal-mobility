using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using WebApi1.Controllers;
using WebApi1.Model;
using WebApi1.Services;
using Assert = Xunit.Assert;

namespace WebApi1Tests;

public class ScooterServiceTests
{
    private readonly ScooterController _scooterController = new  ();
    
    [SetUp]
    public void Setup()
    {
    }

    
    [Test]
    public void Test_Can_Hire_A_Scooter()
    {
        ScooterUser scooterUser = new ScooterUser("Fred");

        ScooterService service = new ScooterService();

        service.HireScooter(scooterUser);

        Assert.NotNull(scooterUser.AssignedScooterId);

    }
    
    [Test]
    public void Test_Can_Hire_Only_One_Scooter()
    {
        ScooterUser scooterUser = new ScooterUser("Fred");

        ScooterService service = new ScooterService();

        service.HireScooter(scooterUser);
        
        Assert.NotNull(scooterUser.AssignedScooterId);
        
        Assert.Throws<Exception>(() => service.HireScooter(scooterUser));
    }
    
    [Test]
    public void Test_Only_One_Scooter_Can_Be_Hired()
    {
        ScooterUser scooterUser1 = new ScooterUser("Fred");
        ScooterUser scooterUser2 = new ScooterUser("Fred");
        
        ScooterService service = new ScooterService();

        service.HireScooter(scooterUser1);
        service.HireScooter(scooterUser2);
        
        Assert.NotNull(scooterUser1.AssignedScooterId);
        Assert.NotNull(scooterUser2.AssignedScooterId);
        
        Assert.NotEqual(scooterUser1.AssignedScooterId, scooterUser2.AssignedScooterId);
    }
}