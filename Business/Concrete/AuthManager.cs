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
    public class AuthManager : IAuthService
    {
        IWriterDal _writerDal;

        public AuthManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer GetWriter(string mail, string password)
        {
            return _writerDal.Get(x => x.WriterMail == mail && x.WriterPassword == password);
        }

        public void Register(Writer writer)
        {
            writer.WriterAbout = null;
            writer.WriterImage = null;
            writer.WriterStatus = true;
            _writerDal.Add(writer);
        }
    }
}
