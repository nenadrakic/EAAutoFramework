using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace EAAutoFramework.Base
{
	public class BrowserFactory
	{
		public IWebDriver Create(BrowserType browserType = BrowserType.FireFox)
		{
			switch (browserType)
			{
				case BrowserType.Chrome:
					return GetChromeDriver();
				case BrowserType.FireFox:
					return GetFireFoxDriver();
				case BrowserType.Ie:
					return GetIeDriver();
				default:
					throw new ArgumentOutOfRangeException("No souch browser exists");
			}
		}

		private IWebDriver GetChromeDriver()
		{
			return new ChromeDriver("Drivers/");
		}
		private IWebDriver GetFireFoxDriver() => new FirefoxDriver();

		private IWebDriver GetIeDriver()
		{
			var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			return new InternetExplorerDriver(outPutDirectory);
		}
	}

	public enum BrowserType
	{
		Chrome,
		FireFox,
		Ie,
	}
}
