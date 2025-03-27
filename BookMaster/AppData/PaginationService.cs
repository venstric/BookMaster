using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMaster.Model;
using System.Collections.Generic;

namespace BookMaster.AppData
{
    public class PaginationService
    {
        private const int PAGE_SIZE = 50;
        private readonly List<Book> _books;
        private int _currentPageIndex = 0;
        private int _currentPageNumber = 1;


        public int BooksCount => _books.Count;
        public int TotalPages => (BooksCount + PAGE_SIZE - 1) / PAGE_SIZE;
        public List<Book> CurrentPageOfBooks => _books.Skip(_currentPageIndex * 
            PAGE_SIZE).Take(PAGE_SIZE).ToList();

        public PaginationService(List<Book> books)
        {
            _books = books;
        }
    }
}
