using System;
using System.Threading;
using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace EAAutoFramework.Extensions
{
	public static class ElementExtensions
	{
		public static void JsClick(this IWebElement element)
		{
				//var rwe = (RemoteWebElement)element;
				//var driver = rwe.WrappedDriver;
				//IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
			IJavaScriptExecutor js = (IJavaScriptExecutor)DriverContext.Driver;
			js.ExecuteScript("arguments[0].click();", element);			
		}

		public static void SelectDropDownList(this IWebElement element, string value)
		{
			SelectElement ddl = new SelectElement(element);
			ddl.SelectByText(value);
		}

		public static void AssertElementPresent(this IWebElement element)
		{
			if (!IsElementPresent(element))
				throw new Exception(string.Format("Element Not present exception"));
		}

		private static bool IsElementPresent(IWebElement element)
		{
			try
			{
				bool ele = element.Displayed;
				return true;
			}
			catch (Exception e)
			{
				return false;
			}
		}

		public static string WaitUntilHasText(this IWebElement element)
		{
			var started = DateTime.Now;
			var elementText = element.Text;
			while (string.IsNullOrWhiteSpace(elementText) && started > DateTime.Now.Subtract(TimeSpan.FromSeconds(30)))
			{
				Thread.Sleep(200);
				elementText = element.Text;
			}
			return elementText;
		}
	}
}
