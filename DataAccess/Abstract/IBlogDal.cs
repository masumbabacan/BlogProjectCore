using DataAccess.EntityGenericRepository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogDal : IEntityRepository<Blog>
    {
        List<Blog> GetBlogListWithCategory();  // Blog listesinde blogların kategorilerini isimleriyle birlikte getirmesi için İnclude Metodunu ve IBlogDal interface'ine tanımladık.
        List<Blog> GetBlogListWithCategoryByWriter(int id);
    }
}
