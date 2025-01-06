using MyApiBook_1.BusinessLayer.Abstract;
using MyApiBook_1.DataAccessLayer.Abstract;
using MyApiBook_1.DataAccessLayer.Context;
using MyApiBook_1.EntityLayer.Concrete;
using MyApiBook_1.EntityLayer.ViewModel;
using MyApiBook_1.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace MyApiBook_1.BusinessLayer.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void TDelete(int id)
        {
            _bookDal.Delete(id);
        }

        public List<Book> TGetAll()
        {
            return _bookDal.GetAll();
        }

        public Book TGetById(int id)
        {
            return _bookDal.GetById(id);
        }

        public void TInsert(Book entity)
        {
            _bookDal.Insert(entity);
        }

        public List<BookCategoryWriterViewModel> TLast4BooksList()
        {
            return _bookDal.Last4BooksList();
        }



        public void TUpdate(Book entity)
        {
            _bookDal.Update(entity);
        }

        public List<Random1BookViewModel> TRandom1Book()
        {
            return _bookDal.Random1Book();
        }

        public List<AllProductsInformationViewModel> TPopulerBookAllCategories()
        {
            return _bookDal.PopulerBookAllCategories();
        }

        public List<AllProductsInformationViewModel> TPopulerBookRoman()
        {
            return _bookDal.PopulerBookRoman();
        }

        public List<AllProductsInformationViewModel> TPopulerBookEdebiyat()
        {
            return _bookDal.PopulerBookEdebiyat();
        }

        public List<AllProductsInformationViewModel> TPopulerBookTarih()
        {
            return _bookDal.PopulerBookTarih();
        }

        public List<AllProductsInformationViewModel> TPopulerBookKisiselGelisim()
        {
            return _bookDal.PopulerBookKisiselGelisim();
        }

        public List<AllProductsInformationViewModel> TPopulerBookCocuk()
        {
            return _bookDal.PopulerBookCocuk();
        }
    }
}
