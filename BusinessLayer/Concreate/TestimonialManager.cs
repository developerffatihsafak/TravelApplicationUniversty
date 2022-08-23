using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concreate
{
    public class TestimonialManager : ITestimonialService
    {
        ITestiMonialDal _testiMonialDal;

        public TestimonialManager(ITestiMonialDal testiMonialDal)
        {
            _testiMonialDal = testiMonialDal;
        }

        public void TAdd(TestiMonial t)
        {
            _testiMonialDal.Insert(t);
        }

        public void TDelete(TestiMonial t)
        {
            _testiMonialDal.Delete(t);
        }

        public TestiMonial TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TestiMonial> TGetList()
        {
           return _testiMonialDal.GetList();
        }

        public void TUpdate(TestiMonial t)
        {
            _testiMonialDal.Update(t);
        }
    }
}
