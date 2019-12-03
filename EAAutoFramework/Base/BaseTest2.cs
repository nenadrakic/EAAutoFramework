using EAAutoFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace EAAutoFramework.Base
{
	public class BaseTest2
	{
		IWebDriver Driver;
		IWebDriver Driver2;

		private  LoginPage _login;
		private LoginPage _login2;

		[TestInitialize]
		public void Initialize()
		{
		}

		[TestCleanup]
		public void Clean()
		{
			Driver.Close();
			Driver.Quit();
			Driver2.Close();
			Driver2.Quit();
		}

		public LoginPage Login
		{
			get
			{
				if (_login == null)
				{
					var factory = new BrowserFactory();
					Driver = factory.Create(BrowserType.FireFox);
					_login = new LoginPage(Driver);
				}

				return _login;
			}
		}
		public LoginPage Login2
		{
			get
			{
				if (_login2 == null)
				{
					var factory = new BrowserFactory();
					Driver2 = factory.Create(BrowserType.FireFox);
					_login2 = new LoginPage(Driver2);
				}

				return _login2;
			}
		}
	}
}
