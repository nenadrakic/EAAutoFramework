using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace EAAutoFramework.Pages
{
	public class LoginPageDriverContext : BasePageDriverContext<LoginPageDriverContextRepository>
	{
	
		public LoginPageDriverContext(): base(new LoginPageDriverContextRepository())
		{	

		}
		public void GoTo()
		{
			DriverContext.Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
		}

		public void Login(string userName, string password)
		{
			ObjectRepository.txtUserName.SendKeys(userName);
			ObjectRepository.txtPassword.SendKeys(password);
			wait.Until(ElementToBeClickable(ObjectRepository.btnLogin)).Submit();
		}

		public void ClickLoginLink()
		{
			ObjectRepository.lnkLogin.JsClick();
		}

		public EmployeePageDrivenContext ClickEmployeeList()
		{
			ObjectRepository.lnkEmployeeList.Click();
			return new EmployeePageDrivenContext();
		}

	
	}
}
