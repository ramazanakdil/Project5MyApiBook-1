using MyApiBook_1.EntityLayer.Concrete;
using MyApiBook_1.EntityLayer.ViewModel;
using MyApiBook_1.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiBook_1.DataAccessLayer.Abstract
{
    public interface IBookDal : IGenericDal<Book>
    {
        List<BookCategoryWriterViewModel> Last4BooksList();

        List<Random1BookViewModel> Random1Book();

    }
}
