using OpenQA.Selenium;

namespace EAAutoFramework.Base
{
    public abstract class BasePage
    {
	    protected IWebDriver Driver { get; set; }

	    public BasePage(IWebDriver driver)
	    {
		    Driver = driver;
	    }
	}
}
