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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog entity)
        {
            _blogDal.Add(entity);
        }

        public void Delete(Blog entity)
        {
            _blogDal.Delete(entity);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public List<Blog> GetBlogByWriter(int id)
        {
            return _blogDal.GetAll(x=>x.WriterId == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetBlogListWithCategory();
        }

        public List<Blog> GetLastThereeBlog()
        {
            return _blogDal.GetAll().Take(3).ToList();
        }

        public Blog GetById(int id)
        {
            return _blogDal.Get(b => b.BlogId == id);
        }

        public void Update(Blog entity)
        {
            _blogDal.Update(entity);
        }
    }
}
