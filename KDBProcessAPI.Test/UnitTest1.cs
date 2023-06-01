using KDBProcessAPI.Controllers;
using Microsoft.Extensions.Logging;
using NUnit.Framework.Internal;

namespace KDBProcessAPI.Test;

public class Tests
{
    private WeatherForecastController controller;
    [SetUp]
    public void Setup()
    {
        controller = new WeatherForecastController();
    }
    
    [Test]
    public void TestGetWeatherForcastIsList()
    {
        Assert.That(new WeatherForecast[0].GetType(), Is.EqualTo(controller.Get().GetType()));
    }

    [Test]
    public void TestGetWeatherForcastType()
    {
        Assert.That(new WeatherForecast().GetType(), Is.EqualTo(controller.Get().First().GetType()));
    }
}