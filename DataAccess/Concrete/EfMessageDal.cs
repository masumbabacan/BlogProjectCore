﻿using DataAccess.Abstract;
using DataAccess.EntityGenericRepository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfMessageDal : EfEntityRepositoryBase<Message, Context>, IMessageDal
    {
    }
}
