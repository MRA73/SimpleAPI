using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController weatherForecastController = new WeatherForecastController(null);

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // [Fact]
        // public void GetReturnWeatherForecastByName()
        // {
        //     var weatherForecast = weatherForecastController.Get("Bracing");
        //     var result = weatherForecast.Value;
        //     Console.WriteLine($"Summary : {result.Summary}");
        //     Assert.Equal("Bracing", result.Summary);
        //     // Assert.Equal("Bracing", "Bracing");
        // }

        [Fact]
        public void GetReturnWeatherForecastByName()
        {
            var result = weatherForecastController.Get(1);   
            Assert.NotNull(result);
            Assert.Equal("Bracing", result.Value);
        }


        [Fact]
        public void Test1()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
