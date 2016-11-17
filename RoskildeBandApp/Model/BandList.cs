using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace RoskildeBandApp.Model
{
   public class BandList : ObservableCollection<Band>
    {

        public BandList() : base()
        {
            // Band band1 = new Band();

            this.Add(new Band() { bandNavn = "U2", anmeldelser = "Gode", scene = "orange scenen" });

        }
    }
}
