using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Testc
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

        [Fact]
        public void GetReturnWeatherForecastByName()
        {
            var result = weatherForecastController.Get(2);   
            Assert.NotNull(result);
            // var expected = "Bracing";
            Assert.Equal("Chilly", result.Value);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
