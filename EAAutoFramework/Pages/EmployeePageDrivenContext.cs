using EAAutoFramework.Base;

namespace EAAutoFramework.Pages
{
	public class EmployeePageDrivenContext : BasePageDriverContext<EmployeePageDrivenContextRepository>
	{
		public EmployeePageDrivenContext() : base(new EmployeePageDrivenContextRepository())
		{
		}
		public bool IsCreateNewButtonAvailable()
		{
			return ObjectRepository.linkCreateNew.Displayed;
		}

	
	}
}
