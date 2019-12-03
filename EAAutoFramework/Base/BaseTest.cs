using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace EAAutoFramework.Base
{
	public class BaseTest
	{
		public IWebDriver Driver { get; set; }

		[TestInitialize]
		public void Initialize()
		{
			var factory = new BrowserFactory();
			Driver = factory.Create(BrowserType.FireFox);
		}

		[TestCleanup]
		public void Clean()
		{
			Driver.Close();
			Driver.Quit();
		}
	}
}
