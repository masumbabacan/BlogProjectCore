using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void Add(NewsLetter entity)
        {
            entity.MailStatus = true;
            _newsLetterDal.Add(entity);
        }

        public void Delete(NewsLetter entity)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> GetAll()
        {
            throw new NotImplementedException();
        }

        public NewsLetter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(NewsLetter entity)
        {
            throw new NotImplementedException();
        }
    }
}
