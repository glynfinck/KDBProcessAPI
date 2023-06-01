using KDBProcessAPI.Controllers;
using Microsoft.Extensions.Logging;
using NUnit.Framework.Internal;

namespace KDBProcessAPI.Test;

public class Tests
{
    private WeatherForecastController _controller;
    [SetUp]
    public void Setup()
    {
        _controller = new WeatherForecastController();
    }
    
    [Test]
    public void TestGetWeatherForcastIsList()
    {
        Assert.That(Array.Empty<WeatherForecast>().GetType(), Is.EqualTo(_controller.Get().GetType()));
    }

    [Test]
    public void TestGetWeatherForcastType()
    {
        Assert.That(new WeatherForecast().GetType(), Is.EqualTo(_controller.Get().First().GetType()));
    }
}