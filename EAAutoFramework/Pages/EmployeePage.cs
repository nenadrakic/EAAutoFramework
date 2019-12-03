using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace EAAutoFramework.Pages
{
	public class EmployeePage : BasePage
	{
		public EmployeePage(IWebDriver driver) : base(driver)
		{
		}
		//Login link text
		IWebElement txtSearch => Driver.FindElement(By.Name("searchTerm"));

		IWebElement lnkCreateNew => Driver.FindElement(By.LinkText("Create New"));

		public CreateEmployeePage ClickCreateNew()		{
			lnkCreateNew.Click();
			return new CreateEmployeePage();
		}


	}
}
