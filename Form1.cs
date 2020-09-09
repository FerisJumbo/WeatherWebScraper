using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace WeatherWebScrapper
{
    public partial class WeatherWebScraper : Form
    {
        readonly private int highTempIndex = 26;
        readonly private int lowTempIndex = 29;
        readonly private int recordHighIndex = 28;
        readonly private int recordLowIndex = 31;
        readonly private int pressureIndex = 20;
        //readonly private int windSpeedIndex = 13;
        //readonly private int windDirectionIndex = 13;
        readonly private int dewPointIndex = 22;
        readonly private int currentTempIndex = 13;
        readonly private int heatIndexIndex = 0;
        readonly private int sunRiseIndex = 0;
        readonly private int sunSetIndex = 1;
        readonly private int moonRiseIndex = 14;
        readonly private int moonSetIndex = 15;
        //readonly private int moonPhaseIndex = 13;

        static String weatherBransonMO;
        static String weatherNaplesFL;
        static String weatherHutchMN;

        Weather weather;

        ChromeDriver chromeDriver;

        public WeatherWebScraper()
        {
            InitializeComponent();
        }

        private void WeatherWebScraper_Load(object sender, EventArgs e)
        {
            weatherBransonMO = "https://www.wunderground.com/weather/us/mo/branson";
            weatherNaplesFL = "https://www.wunderground.com/weather/us/fl/naples";
            weatherHutchMN = "https://www.wunderground.com/weather/us/mn/hutchinson";

            btnBranson.Enabled = true;
            btnNaples.Enabled = true;

            txtbxCustomURL.Enabled = false;
            btnVisitWeb.Enabled = false;
            lblInfo.Enabled = false;

            numIndexError.Value = 1;

            txtbxCustomURL.Text = "https://www.wunderground.com/weather/";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-gpu");

            weather = new Weather();
            chromeDriver = new ChromeDriver(options);
        }

        private void btnScrape_Click(object sender, EventArgs e)
        {
            radEnglish.Checked = true;

            try
            {
                ReadOnlyCollection<IWebElement> wTemps = chromeDriver.FindElementsByCssSelector(".wu-value-to");
                ReadOnlyCollection<IWebElement> wCloudCoverage = chromeDriver.FindElementsByCssSelector(".wx-value");
                IWebElement wWindSpead = chromeDriver.FindElementByCssSelector(".wind-speed");
                ReadOnlyCollection<IWebElement> wTemps2 = chromeDriver.FindElementsByCssSelector(".temp");
                ReadOnlyCollection<IWebElement> wTimes = chromeDriver.FindElementsByCssSelector(".data-point");
                IWebElement wPhase = chromeDriver.FindElementByCssSelector(".phase-name");

                weather.highTemp = double.Parse(wTemps[highTempIndex + Int32.Parse(numIndexError.Value.ToString())].Text);
                weather.lowTemp = double.Parse(wTemps[lowTempIndex + Int32.Parse(numIndexError.Value.ToString())].Text);
                weather.recordHigh = double.Parse(wTemps[recordHighIndex + Int32.Parse(numIndexError.Value.ToString())].Text);
                weather.recordLow = double.Parse(wTemps[recordLowIndex + Int32.Parse(numIndexError.Value.ToString())].Text);
                weather.cloudCover = wCloudCoverage[1].Text;
                weather.pressure = double.Parse(wTemps[pressureIndex + Int32.Parse(numIndexError.Value.ToString())].Text);
                weather.windSpeed = double.Parse(wWindSpead.Text);
                weather.dewPoint = double.Parse(wTemps[dewPointIndex + Int32.Parse(numIndexError.Value.ToString())].Text);
                weather.currentTemp = Int32.Parse(wTemps[currentTempIndex].Text);
                weather.heatIndex = removeRawDegree(wTemps2[heatIndexIndex].Text);
                weather.timeOfDay = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time")).ToString("HH:mm");
                weather.sunRise = wTimes[sunRiseIndex].Text;
                weather.sunSet = wTimes[sunRiseIndex].Text;
                weather.moonRise = wTimes[moonRiseIndex].Text;
                weather.moonSet = wTimes[moonSetIndex].Text;
                weather.moonPhase = wPhase.Text;
                UpdateFields();

                foreach (IWebElement value in wTimes)
                {
                    txtbxDEBUG.Text += value.Text + "-";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Scrapping Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string normalizeTime(string timeOfDay)
        {
            char[] timeArray = timeOfDay.ToCharArray();
            string hours = "";
            string mins = "";
            bool onHours = true;

            foreach (char character in timeArray)
            {
                if (character != ':')
                {
                    if (onHours)
                    {
                        hours += character;
                    } else
                    {
                        mins += character;
                    }
                } else
                {
                    onHours = false;
                }
            }

            if (Int32.Parse(hours) < 12)
            {
                return (hours + ":" + mins + "AM");
            } else if (hours == "12")
            {
                return (hours + ":" + mins + "PM");
            } else if (hours == "24") {
                return (Int32.Parse(hours) - 12 + ":" + mins + " AM");
            } else
            {
                return (Int32.Parse(hours) - 12 + ":" + mins + " PM");
            }
        }

        private string addTime(string time, int hoursToAdd)
        {
            char[] timeArray = time.ToCharArray();
            string hours = "";
            string mins = "";
            bool onHours = true;

            foreach (char character in timeArray)
            {
                if (character != ':')
                {
                    if (onHours)
                    {
                        hours += character;
                    }
                    else
                    {
                        mins += character;
                    }
                }
                else
                {
                    onHours = false;
                }
            }

            hours = (Int32.Parse(hours) + hoursToAdd).ToString();
            return hours + ":" + mins;
        }

        private void btnBranson_Click(object sender, EventArgs e)
        {
            chromeDriver.Navigate().GoToUrl(weatherBransonMO);
        }

        private void btnNaples_Click(object sender, EventArgs e)
        {
            chromeDriver.Navigate().GoToUrl(weatherNaplesFL);
        }

        private void btnHutch_Click(object sender, EventArgs e)
        {
            chromeDriver.Navigate().GoToUrl(weatherHutchMN);
        }

        private void btnVisitWeb_Click(object sender, EventArgs e)
        {
            chromeDriver.Navigate().GoToUrl(txtbxCustomURL.Text);
        }

        private double removeRawDegree(string e)
        {
            string returnString = "";
            string rawString = e;
            char[] charArray = rawString.ToCharArray();
            foreach (char num in charArray)
            {
                if (num != '°')
                {
                    returnString += num;
                }
            }
            return double.Parse(returnString);
        }

        private void UpdateFields()
        {
            try
            {
                txtbxHigh.Text = weather.highTemp.ToString();
                txtbxLow.Text = weather.lowTemp.ToString();
                txtbxRecHigh.Text = weather.recordHigh.ToString();
                txtbxRecLow.Text = weather.recordLow.ToString();
                txtbxCloudCover.Text = weather.cloudCover.ToString();
                txtbxPressure.Text = weather.pressure.ToString();
                txtbxWindSD.Text = weather.windSpeed.ToString();
                txtbxDew.Text = weather.dewPoint.ToString();
                txtbxCurrentTemp.Text = weather.currentTemp.ToString();
                txtbxWCHI.Text = weather.heatIndex.ToString();
                txtbxMoonPhase.Text = weather.moonPhase;

                if (weather.usingEnglish)
                {
                    txtbxHigh.Text += " °F";
                    txtbxLow.Text += " °F";
                    txtbxRecHigh.Text += " °F";
                    txtbxRecLow.Text += " °F";
                    txtbxPressure.Text += " in Hg";
                    txtbxWindSD.Text += " mph / ";
                    txtbxDew.Text += " °F";
                    txtbxCurrentTemp.Text += " °F";
                    txtbxWCHI.Text += " °F";

                    txtbxTofD.Text = normalizeTime(weather.timeOfDay);
                    txtbxSunRS.Text = weather.sunRise + " AM/ " + weather.sunSet + " PM";
                    txtbxMoonRS.Text = weather.moonRise + " PM/ " + weather.moonSet + " AM";
                }
                else
                {
                    txtbxHigh.Text += " °C";
                    txtbxLow.Text += " °C";
                    txtbxRecHigh.Text += " °C";
                    txtbxRecLow.Text += " °C";
                    txtbxPressure.Text += " mm Hg";
                    txtbxWindSD.Text += " m/s / ";
                    txtbxDew.Text += " °C";
                    txtbxCurrentTemp.Text += " °C";
                    txtbxWCHI.Text += " °C";

                    txtbxTofD.Text = weather.timeOfDay;
                    txtbxSunRS.Text = weather.sunRise + " / " + addTime(weather.sunSet, 12);
                    txtbxMoonRS.Text = addTime(weather.moonRise, 12) + " / " + weather.moonSet;
                }
            }
            catch (Exception error)
            {
                radEnglish.Checked = true;
                MessageBox.Show(error.Message, "Scrapping Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radPresets_CheckedChanged(object sender, EventArgs e)
        {
            if (radPresets.Checked)
            {
                btnBranson.Enabled = true;
                btnNaples.Enabled = true;
                btnHutch.Enabled = true;

                txtbxCustomURL.Enabled = false;
                btnVisitWeb.Enabled = false;
                lblInfo.Enabled = false;
            }
            else
            {
                btnBranson.Enabled = false;
                btnNaples.Enabled = false;
                btnHutch.Enabled = false;

                txtbxCustomURL.Enabled = true;
                btnVisitWeb.Enabled = true;
                lblInfo.Enabled = true;
            }
        }

        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (radEnglish.Checked)
            {
                weather.convertUnits("English");
            }
            if (radMetrics.Checked)
            {
                weather.convertUnits("Metric");
            }

            UpdateFields();
        }

        private void txtbxHigh_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxHigh.Text);
        }

        private void txtbxLow_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxLow.Text);
        }

        private void txtbxRecHigh_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxRecHigh.Text);
        }

        private void txtbxRecLow_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxRecLow.Text);
        }

        private void txtbxCloudCover_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxCloudCover.Text);
        }

        private void txtbxPressure_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxPressure.Text);
        }

        private void txtbxWindSD_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxWindSD.Text);
        }

        private void txtbxDew_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxDew.Text);
        }

        private void txtbxCurrentTemp_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxCurrentTemp.Text);
        }

        private void txtbxWCHI_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxWCHI.Text);
        }

        private void txtbxTofD_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxTofD.Text);
        }

        private void txtbxSunRS_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxSunRS.Text);
        }

        private void txtbxMoonRS_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxMoonRS.Text);
        }

        private void txtbxMoonPhase_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxMoonPhase.Text);
        }

        private void WeatherWebScraper_FormClosing(object sender, FormClosingEventArgs e)
        {
            chromeDriver.Quit();
        }
    }
}
