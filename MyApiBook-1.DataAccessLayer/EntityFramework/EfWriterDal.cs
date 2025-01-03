using MyApiBook_1.DataAccessLayer.Abstract;
using MyApiBook_1.DataAccessLayer.Context;
using MyApiBook_1.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiBook_1.DataAccessLayer.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        public EfWriterDal(ApiContext context) : base(context)
        {
        }
    }
}
