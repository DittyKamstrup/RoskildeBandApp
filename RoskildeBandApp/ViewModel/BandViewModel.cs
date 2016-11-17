using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RoskildeBandApp.ViewModel
{
    public class BandViewModel : INotifyPropertyChanged
    {
        public Model.BandList Bandliste { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        public Model.Band SelectedBand
        {
            get { return SelectedBand; }
            set { SelectedBand = value;
                OnPropertyChanged(nameof(SelectedBand));
            }
        }


        protected virtual void onPropertyChanged(string propertyname)
        {
            onPropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }

        public BandViewModel()
        {
            Bandliste = new Model.BandList();
            SelectedBand = new Model.Band();

        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }
    }
}
