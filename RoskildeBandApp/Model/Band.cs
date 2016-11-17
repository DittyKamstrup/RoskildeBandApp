using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeBandApp.Model
{
    public class Band
    {
        public string bandNavn { get; set; }
        public string anmeldelser { get; set; }
        public string sanger { get; set; }
        public string scene { get; set; }

        public override string ToString()
        {
            return bandNavn + "" + scene;
        }
    }
}
