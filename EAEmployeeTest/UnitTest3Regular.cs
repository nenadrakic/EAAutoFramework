using System;
using EAAutoFramework.Base;
using EAAutoFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EAEmployeeTest
{
	[TestClass]
	public class UnitTest3Regular: BaseTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			LoginPage page = new LoginPage(Driver);

			page.GoTo();
			page.ClickLoginLink();
			page.Login("admin", "password");
			var employeeList = page.ClickEmployeeList();
			employeeList.ClickCreateNew();
		}
	}
}
