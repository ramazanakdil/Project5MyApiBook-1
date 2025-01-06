using MyApiBook_1.EntityLayer.Concrete;
using MyApiBook_1.EntityLayer.ViewModel;
using MyApiBook_1.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiBook_1.BusinessLayer.Abstract
{
    public interface IBookService : IGenericService<Book>
    {
        List<BookCategoryWriterViewModel> TLast4BooksList();
        List<Random1BookViewModel> TRandom1Book();
        List<AllProductsInformationViewModel> TPopulerBookAllCategories();
        List<AllProductsInformationViewModel> TPopulerBookRoman();
        List<AllProductsInformationViewModel> TPopulerBookEdebiyat();
        List<AllProductsInformationViewModel> TPopulerBookTarih();
        List<AllProductsInformationViewModel> TPopulerBookKisiselGelisim();
        List<AllProductsInformationViewModel> TPopulerBookCocuk();
    }
}
