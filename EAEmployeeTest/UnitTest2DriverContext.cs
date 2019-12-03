using System;
using EAAutoFramework.Base;
using EAAutoFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EAEmployeeTest
{
	[TestClass]
	public class UnitTest2DriverContext : BaseTestsDriverContext
	{
		[TestMethod]
		public void TestMethod1()
		{
			LoginPageDriverContext loginPage = new LoginPageDriverContext();
			loginPage.GoTo();
			loginPage.ClickLoginLink();
			loginPage.Login("admin", "password");
			var employeePage = loginPage.ClickEmployeeList();

			Assert.IsTrue(employeePage.IsCreateNewButtonAvailable(), "'Create New' button is not available");
		}
	}
}
