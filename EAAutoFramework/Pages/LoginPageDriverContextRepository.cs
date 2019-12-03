using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace EAAutoFramework.Pages
{
	public class LoginPageDriverContextRepository
	{
		//Login link text
		public IWebElement lnkLogin => DriverContext.Driver.FindElement(By.LinkText("Login"));
		//Employee list
		public IWebElement lnkEmployeeList => DriverContext.Driver.FindElement(By.LinkText("Employee List"));
		//Username and password
		public IWebElement txtUserName => DriverContext.Driver.FindElement(By.Id("UserName"));
		public IWebElement txtPassword => DriverContext.Driver.FindElement(By.Id("Password"));
		//Submit button
		public IWebElement btnLogin => DriverContext.Driver.FindElement(By.CssSelector("input.btn"));
	}
}
