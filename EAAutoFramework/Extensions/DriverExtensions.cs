using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace EAAutoFramework.Extensions
{
	public static class DriverExtensions
	{
		public static IJavaScriptExecutor Scripts(this IWebDriver driver)
		{
			return (IJavaScriptExecutor)driver;
		}

		public static IWebElement LocateElement(this IWebDriver driver, By by, int timeoutInSeconds)
		{

			if (timeoutInSeconds > 0)
			{
				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
				return wait.Until(drv => drv.FindElement(by));
			}
			return driver.FindElement(by);
		}

	}
}
