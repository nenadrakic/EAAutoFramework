using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EAAutoFramework.Base
{
	public class BaseTestsDriverContext
	{
		[TestInitialize]
		public void Initialize()
		{
			var factory = new BrowserFactory();
			DriverContext.Driver = factory.Create(BrowserType.Chrome);
		}

		[TestCleanup]
		public void CleanUp()
		{
			DriverContext.Driver.Close();
			DriverContext.Driver.Quit();
		}
	}
}
