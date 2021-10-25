﻿using Business.EntityBusinessGenericRepository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        public List<Comment> GetAllCommentByBlog(int id);
    }
}
