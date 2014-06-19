using GalaSoft.MvvmLight;

namespace ListBoxBinding.Model
{
    public class BookModel : ObservableObject
    {
        public BookModel(string title, string author, int pages)
            : base()
        {
            this.Title = title;
            this.Author = author;
            this.Pages = pages;
        }

        #region Properties

        private string _title;
        public string Title
        {
            get { return this._title; }
            set { this.Set<string>(ref this._title, value); }
        }

        private string _author;
        public string Author
        {
            get { return this._author; }
            set { this.Set<string>(ref this._author, value); }
        }

        private int _pages;
        public int Pages
        {
            get { return this._pages; }
            set { this.Set<int>(ref this._pages, value); }
        }

        #endregion
    }
}

