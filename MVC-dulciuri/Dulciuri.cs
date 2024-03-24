using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_dulciuri
{
    public class Dulciuri
    {
        public double _pret;
        public int _gramaj;
        public string _tipDulce;

        public double pret
        {
            get { return _pret; }
            set { _pret = value; }
        }

        public int gramaj
        {
            get { return _gramaj; }
            set { _gramaj = value; }
        }

        public string tipDulce
        {
            get { return _tipDulce; }
            set { _tipDulce = value; }
        }


        public string DulciuriInfo()
        {
            string text = " ";
            text += "Pret" + pret + "\n";
            text += "Gramaj" + gramaj + "\n";
            text += "Tip Dulciuri" + tipDulce + "\n";
            return text;
        }
    }
}
