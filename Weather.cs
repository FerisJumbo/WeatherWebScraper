using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWebScrapper
{
    public class Weather
    {
        public bool usingEnglish;

        public double highTemp;
        public double lowTemp;
        public double recordHigh;
        public double recordLow;
        public String cloudCover;
        public double pressure;
        public double windSpeed;
        public string windDirection;
        public double dewPoint;
        public double currentTemp;
        public double heatIndex;
        public String timeOfDay;
        public String sunRise;
        public String sunSet;
        public String moonRise;
        public String moonSet;
        public String moonPhase;

        public Weather()
        {
            usingEnglish = true;
        }

        public void convertUnits(string units)
        {
            if (units == "English" && !usingEnglish)
            {
                highTemp = toFarenheit(highTemp);
                lowTemp = toFarenheit(lowTemp);
                recordHigh = toFarenheit(recordHigh);
                recordLow = toFarenheit(recordLow);
                pressure = Math.Round(pressure * 29.92 / 760, 2);
                windSpeed = Math.Round((windSpeed * 3600) / 1609, 2); 
                dewPoint = toFarenheit(dewPoint);
                currentTemp = toFarenheit(currentTemp);
                heatIndex = toFarenheit(heatIndex);

                usingEnglish = true;
            }
            else if (units == "Metric" && usingEnglish)
            {
                highTemp = toCelsius(highTemp);
                lowTemp = toCelsius(lowTemp);
                recordHigh = toCelsius(recordHigh);
                recordLow = toCelsius(recordLow);
                pressure = Math.Round(pressure * 760 / 29.92, 2);
                windSpeed = Math.Round((windSpeed * 1609) / 3600, 2);
                dewPoint = toCelsius(dewPoint);
                currentTemp = toCelsius(currentTemp);
                heatIndex = toCelsius(heatIndex);

                usingEnglish = false;
            }
        }

        public double toCelsius(double value)
        {
            return Math.Round((value - 32) * (.5555555), 2);
        }

        public double toFarenheit(double value)
        {
            return Math.Round((value * (1.8)) + 32, 1);
        }
    }
}
