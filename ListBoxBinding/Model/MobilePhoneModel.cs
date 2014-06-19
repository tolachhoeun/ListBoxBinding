using GalaSoft.MvvmLight;

namespace ListBoxBinding.Model
{
    public class MobilePhoneModel : ObservableObject
    {

        public MobilePhoneModel(string name, string oem, string osName, int year)
            : base()
        {
            this.Name = name;
            this.OEM = oem;
            this.OS = osName;
            this.Year = year;
        }

        #region

        private string _name;
        public string Name
        {
            get { return this._name; }
            set { this.Set<string>(ref this._name, value); }
        }

        private string _oem;
        public string OEM
        {
            get { return this._oem; }
            set { this.Set<string>(ref this._oem, value); }
        }

        private string _os;
        public string OS
        {
            get { return this._os; }
            set { this.Set<string>(ref this._os, value); }
        }

        private int _year;
        public int Year
        {
            get { return this._year; }
            set { this.Set<int>(ref this._year, value); }
        }

        #endregion
    }
}

