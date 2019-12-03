using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using OpenQA.Selenium;

namespace EAAutoFramework.Helpers
{
	class StaleElementMethods
	{
		public void ClickOnStaleElement(By element)
		{
			var staleElement = true;
			while (staleElement)
			{
				try
				{
					DriverContext.Driver.LocateElement(element, 10).Click();
					staleElement = false;

				}
				catch (StaleElementReferenceException)
				{
					staleElement = true;
				}
			}
		}
	}
}
