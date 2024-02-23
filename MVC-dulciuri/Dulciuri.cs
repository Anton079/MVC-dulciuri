using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_dulciuri
{
    public class Dulciuri
    {
        public double pret;
        public int gramaj;
        public string tipDulce;

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
