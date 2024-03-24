using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_dulciuri
{
    public class DulciuriService
    {
        private List <Dulciuri> _DulciuriList;

        public DulciuriService()
        {
            _DulciuriList = new List<Dulciuri>();
            this.LoadData();
        }

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

            this._DulciuriList.Add(Produs1);
            this._DulciuriList.Add(Produs2);
            this._DulciuriList.Add(Produs3);
            this._DulciuriList.Add(Produs4);
            this._DulciuriList.Add(Produs5);

        }


        //CRUD
        public void AfisareDulciuri()
        {
            foreach(Dulciuri x in _DulciuriList)
            {
                Console.WriteLine(x.DulciuriInfo());
            }
        }

        public int FindDulciuriByTipDulce(string TipDulce)
        {
            for(int i = 0; i < _DulciuriList.Count; i++)
            {
                if (_DulciuriList[i].Equals(TipDulce))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool AddDulciuriinList(Dulciuri dulciuriNoi) 
        {
            if(FindDulciuriByTipDulce(dulciuriNoi.tipDulce)==-1)
            {
                this._DulciuriList.Add(dulciuriNoi); 
                return true;
            }
        return false;
        }
        
        public bool RemoveDulciuriByDenumire(string dulceCautat)
        {
            int poz = FindDulciuriByTipDulce(dulceCautat);
            if (poz != -1)
            {
                _DulciuriList.RemoveAt(poz);
                return true;

            }
            return false;
        }

        //View

        public int FindDulceByPrice(int dulcePrice)
        {
            for (int i = 0; i < _DulciuriList.Count; i++)
            {
                if (_DulciuriList[i].pret == dulcePrice)
                {
                    Console.WriteLine(i);
                    return 1;
                }
            }
            return -1;
        }

        public bool BuyDulciuri(string DulciuriDorite)
        {
            for (int i = 0; i < _DulciuriList.Count; i++)
            {
                if (_DulciuriList[i].tipDulce == DulciuriDorite)
                {
                    _DulciuriList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool RemoveCameraByDenumire(string dulcCautata)
        {
            int DulceCautat = FindDulciuriByTipDulce(dulcCautata);
            if (DulceCautat != -1)
            {
                _DulciuriList.RemoveAt(DulceCautat);
                return true;

            }
            return false;
        }

        public bool AddDulciuriInList(Dulciuri DulciuriNoi)
        {
            if (FindDulciuriByTipDulce(DulciuriNoi.tipDulce) != -1)
            {
                this._DulciuriList.Add(DulciuriNoi);
                return true;
            }
            return false;
        }

        public bool EditDulciuriDenumire(string dulciuriAles, string newName)
        {
            foreach (Dulciuri x in _DulciuriList)
            {
                if (x.tipDulce == dulciuriAles)
                {
                    x.tipDulce = newName;
                    return true;
                }
            }
            return false;
        }

        public bool EditDulciuriPret(string dulciuriAles, int newPrice)
        {
            foreach (Dulciuri x in _DulciuriList)
            {
                if (x.tipDulce == dulciuriAles)
                {
                    x.pret = newPrice;
                    return true;
                }
            }
            return false;
        }


    }
}
