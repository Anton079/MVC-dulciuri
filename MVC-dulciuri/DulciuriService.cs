using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_dulciuri
{
    public class DulciuriService
    {
        public List <Dulciuri> DulciuriList = new List<Dulciuri>();

        public void LoadData()
        {
            Dulciuri Produs1 = new Dulciuri();
            Produs1.gramaj = 250;
            Produs1.pret = 10;
            Produs1.tipDulce = "Jeleuri";

            Dulciuri Produs2 = new Dulciuri();
            Produs2.gramaj = 200;
            Produs2.pret = 12;
            Produs2.tipDulce = "Ciocolata";

            Dulciuri Produs3 = new Dulciuri();
            Produs3.gramaj = 300;
            Produs3.pret = 5;
            Produs3.tipDulce = "Biscuiti cu ciocolata";

            Dulciuri Produs4 = new Dulciuri();
            Produs4.gramaj = 600;
            Produs4.pret = 7;
            Produs4.tipDulce = "Caramele";

            Dulciuri Produs5 = new Dulciuri();
            Produs5.tipDulce = "Corn cu ciocolata";
            Produs5.gramaj = 300;
            Produs5.pret = 6;

            this.DulciuriList.Add(Produs1);
            this.DulciuriList.Add(Produs2);
            this.DulciuriList.Add(Produs3);
            this.DulciuriList.Add(Produs4);
            this.DulciuriList.Add(Produs5);

        }

        public void AfisareDulciuri()
        {
            foreach(Dulciuri x in DulciuriList)
            {
                Console.WriteLine(x.DulciuriInfo());
            }
        }
    }
}
