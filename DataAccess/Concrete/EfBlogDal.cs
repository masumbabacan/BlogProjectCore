using DataAccess.Abstract;
using DataAccess.EntityGenericRepository;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog, Context>, IBlogDal
    {
        public List<Blog> GetBlogListWithCategory()
        {
            using (Context context = new Context())
            {
                return context.Blogs.Include(x => x.Category).ToList();
            }
        }

        public List<Blog> GetBlogListWithCategoryByWriter(int id)
        {
            using (Context context = new Context())
            {
                return context.Blogs.Include(x => x.Category).Where(x=>x.WriterId == id).ToList();
            }
        }
    }
}
