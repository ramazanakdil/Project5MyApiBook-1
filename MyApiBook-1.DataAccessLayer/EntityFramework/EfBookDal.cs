using MyApiBook_1.DataAccessLayer.Abstract;
using MyApiBook_1.DataAccessLayer.Context;
using MyApiBook_1.EntityLayer.Concrete;
using MyApiBook_1.EntityLayer.ViewModel;
using MyApiBook_1.UI.ViewModel;

namespace MyApiBook_1.DataAccessLayer.EntityFramework
{
    public class EfBookDal : GenericRepository<Book>, IBookDal
    {


        public EfBookDal(ApiContext context) : base(context)
        {
        }

        public List<BookCategoryWriterViewModel> Last4BooksList()
        {
            var context = new ApiContext();
            var values = context.Books
                .OrderByDescending(a => a.BookId)
                .Take(4)
                .Select(book => new BookCategoryWriterViewModel
                {
                    Title = book.Title,
                    ImageUrl = book.ImageUrl,
                    WriterName = book.Writer.Name + " " + book.Writer.Surname,
                    CategoryName = book.Category.CategoryName,
                    Price = book.Price
                })
                .ToList();

            return values;
        }

        public List<AllProductsInformationViewModel> PopulerBookAllCategories()
        {
            var context = new ApiContext();
            var values = context.Books
                .OrderByDescending(a => a.BookId)
                .Take (8)
                .Select(book => new AllProductsInformationViewModel
                {
                    Title = book.Title,
                    ImageUrl = book.ImageUrl,
                    WriterName = book.Writer.Name + " " + book.Writer.Surname,
                    CategoryName = book.Category.CategoryName,
                    Price = book.Price
                })
                .ToList();

            return values;
        }

        public List<AllProductsInformationViewModel> PopulerBookCocuk()
        {
            var context = new ApiContext();
            var values = context.Books
                .OrderByDescending(a => a.BookId)
                .Where(x => x.Category.CategoryName == "Çocuk ve Gelişim")
                .Take(8)
                .Select(book => new AllProductsInformationViewModel
                {
                    Title = book.Title,
                    ImageUrl = book.ImageUrl,
                    WriterName = book.Writer.Name + " " + book.Writer.Surname,
                    CategoryName = book.Category.CategoryName,
                    Price = book.Price
                })
                .ToList();

            return values;
        }

        public List<AllProductsInformationViewModel> PopulerBookEdebiyat()
        {
            var context = new ApiContext();
            var values = context.Books
                .OrderByDescending(a => a.BookId)
                .Where(x => x.Category.CategoryName == "Edebiyat")
                .Take(8)
                .Select(book => new AllProductsInformationViewModel
                {
                    Title = book.Title,
                    ImageUrl = book.ImageUrl,
                    WriterName = book.Writer.Name + " " + book.Writer.Surname,
                    CategoryName = book.Category.CategoryName,
                    Price = book.Price
                })
                .ToList();

            return values;
        }

        public List<AllProductsInformationViewModel> PopulerBookKisiselGelisim()
        {
            var context = new ApiContext();
            var values = context.Books
                .OrderByDescending(a => a.BookId)
                .Where(x => x.Category.CategoryName == "Kişisel Gelişim")
                .Take(8)
                .Select(book => new AllProductsInformationViewModel
                {
                    Title = book.Title,
                    ImageUrl = book.ImageUrl,
                    WriterName = book.Writer.Name + " " + book.Writer.Surname,
                    CategoryName = book.Category.CategoryName,
                    Price = book.Price
                })
                .ToList();

            return values;
        }

        public List<AllProductsInformationViewModel> PopulerBookRoman()
        {
            var context = new ApiContext();
            var values = context.Books
                .OrderByDescending(a => a.BookId)
                .Where(x => x.Category.CategoryName == "Roman")
                .Take(8)
                .Select(book => new AllProductsInformationViewModel
                {
                    Title = book.Title,
                    ImageUrl = book.ImageUrl,
                    WriterName = book.Writer.Name + " " + book.Writer.Surname,
                    CategoryName = book.Category.CategoryName,
                    Price = book.Price
                })
                .ToList();

            return values;
        }

        public List<AllProductsInformationViewModel> PopulerBookTarih()
        {
            var context = new ApiContext();
            var values = context.Books
                .OrderByDescending(a => a.BookId)
                .Where(x => x.Category.CategoryName == "Tarih")
                .Take(8)
                .Select(book => new AllProductsInformationViewModel
                {
                    Title = book.Title,
                    ImageUrl = book.ImageUrl,
                    WriterName = book.Writer.Name + " " + book.Writer.Surname,
                    CategoryName = book.Category.CategoryName,
                    Price = book.Price
                })
                .ToList();

            return values;
        }

        List<Random1BookViewModel> IBookDal.Random1Book()
        {
            var context = new ApiContext();
            var values = context.Books.OrderBy(u => Guid.NewGuid()).Take(1).Select(book => new Random1BookViewModel
            {
                Title = book.Title,
                ImageUrl = book.ImageUrl,
                WriterName = book.Writer.Name + " " + book.Writer.Surname,
                CategoryName = book.Category.CategoryName,
                Price = book.Price,
                Description = book.Description
            }).ToList();
            return values;
        }
    }
}
