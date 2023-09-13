using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TraversalCoreProject.ViewComponents.Default
{
	public class _SubAbout : ViewComponent
	{
		SubAboutManager _subAboutmanager = new SubAboutManager(new EfSubAboutDal());
		public IViewComponentResult Invoke()
		{
			var values = _subAboutmanager.TGetList();
			return View(values);
		}
	}
}
