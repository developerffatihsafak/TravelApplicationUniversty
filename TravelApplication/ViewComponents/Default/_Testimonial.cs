using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelApplication.ViewComponents.Default
{
    public class _Testimonial: ViewComponent
    {
        TestimonialManager testimonial = new TestimonialManager(new EfTestimoialDal());
        public IViewComponentResult Invoke()
        {
            var list = testimonial.TGetList();
            return View(list);
        }
    }
}
