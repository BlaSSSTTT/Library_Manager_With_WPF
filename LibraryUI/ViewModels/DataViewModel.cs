using PortableLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryUI.ViewModels
{
    public class DataViewModel : ViewModelBase
    {
        public DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
            BorrowBookCommand = new Command(BorrowBook);
            AvailableBookCommand = new Command(AvailableBook);
            ReserveBookCommand = new Command(ReserveBook);
            LostBookCommand = new Command(LostBook);
        }
        private string _visibleControl = "Books";

        public string VisibleControl
        {
            get
            {
                return _visibleControl;
            }
            set
            {
                _visibleControl = value;
                OnPropertyChanged("VisibleControl");
            }
        }
        private BookViewModel _selectedBook;

        public BookViewModel SelectedBook
        {
            get
            {
                return _selectedBook;
            }
            set
            {
                _selectedBook = value;
                OnPropertyChanged("SelectedBook");
            }
        }

        public ICommand SetControlVisibility { get; set; }

        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }

        public ICommand BorrowBookCommand { get; set; }

        public void BorrowBook(object args)
        {
           SelectedBook.Status = BookStatus.BORROWED;
        }
        public ICommand AvailableBookCommand { get; set; }

        public void AvailableBook(object args)
        {
            SelectedBook.Status = BookStatus.AVAILABLE;
        }
        public ICommand ReserveBookCommand { get; set; }

        public void ReserveBook(object args)
        {
            SelectedBook.Status = BookStatus.RESERVED;
        }
        public ICommand LostBookCommand { get; set; }

        public void LostBook(object args)
        {
            SelectedBook.Status = BookStatus.LOST;
        }
        private ObservableCollection<AuthorViewModel> _Authors;

        public ObservableCollection<AuthorViewModel> Authors
        {
            get
            {
                return _Authors;
            }
            set
            {
                _Authors = value;
                OnPropertyChanged("Authors");
            }
        }
        private ObservableCollection<BookViewModel> _Books;

        public ObservableCollection<BookViewModel> Books
        {
            get
            {
                return _Books;
            }
            set
            {
                _Books = value;
                OnPropertyChanged("Books");
            }
        }
        private ObservableCollection<ReaderViewModel> _Readers;

        public ObservableCollection<ReaderViewModel> Readers
        {
            get
            {
                return _Readers;
            }
            set
            {
                _Readers = value;
                OnPropertyChanged("Readers");
            }
        }
    }
}
