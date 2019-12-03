using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace EAAutoFramework.Pages
{
	public class LoginPage : BasePage
	{

		public LoginPage(IWebDriver driver) : base(driver)
		{
		}
		//Login link text
		IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
		//Employee list
		IWebElement lnkEmployeeList => Driver.FindElement(By.LinkText("Employee List"));
		//Username and password
		IWebElement txtUserName => Driver.FindElement(By.Id("UserName"));
		IWebElement txtPassword => Driver.FindElement(By.Id("Password"));
		//Submit button
		IWebElement btnLogin => Driver.FindElement(By.CssSelector("input.btn"));

		public void GoTo()
		{
			Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
		}

		public void Login(string userName, string password)
		{
			txtUserName.SendKeys(userName);
			txtPassword.SendKeys(password);
			btnLogin.Submit();
		}

		public void ClickLoginLink()
		{
			lnkLogin.Click();
		}

		public EmployeePage ClickEmployeeList()
		{
			lnkEmployeeList.Click();
			return new EmployeePage(Driver);
		}
	}
}
