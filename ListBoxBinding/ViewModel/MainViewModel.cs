using GalaSoft.MvvmLight;
using ListBoxBinding.Model;
using System.Collections.ObjectModel;

namespace ListBoxBinding.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
            : base()
        {
            this.Products = new ObservableCollection<ObservableObject>();
            this.Products.Add(new BookModel("How to Raise the Perfect Dog: Through Puppyhood and Beyond", "Cesar Millan, Melissa Jo Peltier", 320));
            this.Products.Add(new BookModel("Animal Speak: The Spiritual & Magical Powers of Creatures Great and Small", "Ted Andrews", 400));
            this.Products.Add(new BookModel("Find Momo: A Photography Book", "Andrew Knapp", 144));
            this.Products.Add(new MobilePhoneModel("iPhone5", "Apple", "iOS", 2012));
            this.Products.Add(new MobilePhoneModel("Galxay S5", "Samsun", "Android", 2012));
            this.Products.Add(new MobilePhoneModel("Lumia 920", "Microsoft", "Windows Phone", 2011));
        }

        #region Properties

        public ObservableCollection<ObservableObject> Products
        { get; private set; }

        #endregion
    }
}

