using MyApiBook_1.DataAccessLayer.EntityFramework;
using MyApiBook_1.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiBook_1.BusinessLayer.Abstract
{
    public interface IFeatureService : IGenericService<Feature>
    {
    }
}
