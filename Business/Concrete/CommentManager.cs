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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment entity)
        {
            entity.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            entity.CommentStatus = true;
            entity.BlogId = 1009;
            _commentDal.Add(entity);
        }

        public void Delete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }

        public List<Comment> GetAllCommentByBlog(int id)
        {
            return _commentDal.GetAll(x => x.BlogId == id);
        }

        public Comment GetById(int id)
        {
            return _commentDal.Get(c => c.CommentId == id);
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}
