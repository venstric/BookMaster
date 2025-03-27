using BookMaster.AppData;
using BookMaster.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookMaster.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для BrowserCatalogPage.xaml
    /// </summary>
    public partial class BrowserCatalogPage : Page
    {
        List<Book> _books = App.context.Book.ToList();
        PaginationService _bookPagination;

        public BrowserCatalogPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            SearchResultsGrid.Visibility = Visibility.Visible;

            if (string.IsNullOrEmpty(SearchByBookTitleTb.Text) &&
                string.IsNullOrEmpty(SearchByAuthorNameTb.Text) &&
                string.IsNullOrEmpty(SearchByBookSubjectTb.Text))
            {
                _bookPagination = new PaginationService(_books);
            }
            else
            {
                List<Book> searchResults = _books.Where(book => book.Title.ToLower().Contains(SearchByBookTitleTb.Text.ToLower()) &&
                book.Authors.ToLower().Contains(SearchByAuthorNameTb.Text.ToLower())).ToList();
                //Реализация алгоритма поиска
                _bookPagination = new PaginationService(searchResults);

                //Загружаем данные из таблицы BookAuthors  в список ListView
                BookAuthorLv.ItemsSource = _bookPagination.CurrentPageOfBooks;
                TotalPagesTbl.DataContext = TotalBooksTbl.DataContext = _bookPagination;




            }
        }

        private void PreviousBookBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CurrentPageTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NextBookBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
