using System;
using System.Collections.Generic;
using System.Linq;
using BookMaster.Model;
using System.Windows.Controls;

namespace BookMaster.AppData
{
    public class PaginationService<T>
    {
        private readonly int _pageSize;
        private readonly List<T> _items;
        private int _currentPageIndex = 0;
        private int _currentPageNumber = 1;

        public int CurrentPageNumber
        {
            get
            {
                return _currentPageNumber = _currentPageIndex + 1;
            }
            set
            {
                _currentPageNumber = value - 1;
                _currentPageNumber = value;
            }
        }

        public int ItemsCount => _items.Count;
        public int TotalPages => (ItemsCount + _pageSize - 1) / _pageSize;
        public List<T> CurrentPageOfItems => _items.Skip(_currentPageIndex *
            _pageSize).Take(_pageSize).ToList();

        public PaginationService(List<T> items, int pageSize)
        {
            _items = items;
            _pageSize = pageSize;
        }

        public List<T> PreviousPage()
        {
            if (_currentPageIndex > 0)
            {
                _currentPageIndex--;
            }
            return CurrentPageOfItems;
        }

        public List<T> NextPage()
        {
            if (_currentPageIndex < TotalPages - 1)
            {
                _currentPageIndex++;
            }
            return CurrentPageOfItems;
        }

        public void UpdatePaginationButtons(Button previonsBtn, Button nextBtn)
        {
            previonsBtn.IsEnabled = _currentPageIndex > 0;
            nextBtn.IsEnabled = _currentPageIndex < TotalPages - 1;
        }

        public List<T> SetCurrentPage(int pageNumber)
        {
            CurrentPageNumber = pageNumber;
            return CurrentPageOfItems;
        }
    }
}
