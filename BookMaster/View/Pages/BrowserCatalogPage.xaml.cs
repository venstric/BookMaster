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
        List<BookAuthor> _bookAuthors = App.context.BookAuthor.ToList();
        public BrowserCatalogPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Загружаем данные из таблицы BookAuthor в список ListView
            BookAuthorLv.ItemsSource = _bookAuthors;
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            //Реализация алгоритма поиска
            BookAuthorLv.ItemsSource = _bookAuthors.Where(bookAuthor =>
            bookAuthor.Book.Title.ToLower().Contains(SearchByBookTitleTb.Text.ToLower()) &&
            bookAuthor.Author.Name.ToLower().Contains(SearchByAuthorNameTb.Text.ToLower()));
        }
    }
}
