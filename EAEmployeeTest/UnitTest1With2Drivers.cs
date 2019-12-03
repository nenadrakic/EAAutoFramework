using System;
using EAAutoFramework.Base;
using EAAutoFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EAEmployeeTest
{
	[TestClass]
	public class UnitTest1With2Drivers : BaseTest2
	{
		[TestMethod]
		public void TestMethod1()
		{
			Login.GoTo();
			Login.ClickLoginLink();
			Login.Login("admin", "password");
			var employeeList = Login.ClickEmployeeList();
			employeeList.ClickCreateNew();

			Login2.GoTo();
			Login2.ClickLoginLink();
			Login2.Login("admin", "password");
			var employeeList2 = Login2.ClickEmployeeList();
			employeeList2.ClickCreateNew();
		}
	}
}
