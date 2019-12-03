using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace EAAutoFramework.Pages
{
	public class EmployeePageDrivenContextRepository
	{
		//Login link text
		IWebElement txtSearch => DriverContext.Driver.FindElement(By.Name("searchTerm"));

		public IWebElement linkCreateNew => DriverContext.Driver.FindElement(By.LinkText("Create New"));
	}
}
