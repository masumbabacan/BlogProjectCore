using Business.Abstract;
using Business.EntityBusinessGenericRepository;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About entity)
        {
            _aboutDal.Add(entity);
        }

        public void Delete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public List<About> GetAll()
        {
            return _aboutDal.GetAll();
        }

        public About GetById(int id)
        {
            return _aboutDal.Get(a => a.AboutId == id);
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
