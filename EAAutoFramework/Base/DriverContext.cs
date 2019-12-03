using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace EAAutoFramework.Base
{
	public class DriverContext
	{
		public static IWebDriver Driver { get; set; }

		//private static IWebDriver _driver;

		//public static IWebDriver Driver
		//{
		//	get
		//	{
		//		return _driver;
		//	}
		//	set
		//	{
		//		_driver = value;
		//	}
		//}
	}
}
