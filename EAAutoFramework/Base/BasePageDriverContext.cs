using System;
using OpenQA.Selenium.Support.UI;

namespace EAAutoFramework.Base
{
	public class BasePageDriverContext<TObjectRepository>
	{
		public WebDriverWait wait;
		public TObjectRepository ObjectRepository { get; }

		public BasePageDriverContext(TObjectRepository repository)
		{
			ObjectRepository = repository;
			wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(10));
		}
	}
}
