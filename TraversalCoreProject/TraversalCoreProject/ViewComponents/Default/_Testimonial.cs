using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
	public class _Testimonial : ViewComponent
	{
		TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialsDal());
		public IViewComponentResult Invoke()
		{
			var value = testimonialManager.TGetList();
			return View(value);
		}
	}
}
