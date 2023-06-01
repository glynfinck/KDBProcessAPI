using KDBProcessAPI.Controllers;
using Microsoft.Extensions.Logging;
using NUnit.Framework.Internal;

namespace KDBProcessAPI.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestGetWeatherForcastType()
    {
        WeatherForecastController controller = new WeatherForecastController();
        Assert.That(new WeatherForecast().GetType(), Is.EqualTo(controller.Get().First().GetType()));
    }
}