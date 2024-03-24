using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_dulciuri
{
    public class View
    {
        private DulciuriService _dulciuriService;

        public View()
        {
            _dulciuriService = new DulciuriService();
        }

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate Dulciurile");
            Console.WriteLine("Apsasati tasta 2 ca sa se afiseze toate dulciurile de un anumit gramaj"); //
            Console.WriteLine("Apasati tasta 3 si introduceti dulciurile pe care le doriti");
            Console.WriteLine("Apasati tasta 4 pentru adauga un produs dulce nou");
            Console.WriteLine("Apasati tasta 5 pentru a da remove la un dulce");
            Console.WriteLine("Apasati tasta 6 pentru a edita denumirea unui dulce");
            Console.WriteLine("Apasati tast 7 pentru a edita pretul unui dulce");
            Console.WriteLine("Apasati tasta 8 pentru a afisa toate dulciurile de un anumit pret");
            Console.WriteLine("Apasati tasta 9 pentru a afisa toate dulciurile de un anumit gramaj");
        }

        public void Play()
        {
            bool running = true;
            _dulciuriService.LoadData();

            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        _dulciuriService.AfisareDulciuri();
                        break;

                    case "2":
                        ShowDulciuriAtSamePrice();
                        break;

                    case "3":
                        BuyDulciuri();
                        break;

                    case "4":
                        AddDulce();
                        break;

                    case "5":
                        StergereaUnuiDUlce();
                        break;

                    case "6":
                        EditareDulceDenumire();
                        break;

                    case "7":
                        EditDulciuriPret();
                        break;

                }
            }
        }

        public void ShowDulciuriAtSamePrice()
        {
            Console.WriteLine("La ce pret doriti dulcurile?");
            int dulciuriPrice = Int32.Parse(Console.ReadLine());

            if (_dulciuriService.FindDulceByPrice(dulciuriPrice) != -1)
            {
                Console.WriteLine("Avem la acest pret!");

            }
            else
            {
                Console.WriteLine("Nu avem la acest pret");
            }


        }

        public void BuyDulciuri()
        {
            Console.WriteLine("Ce dulciuri doriti sa cumparati din lista de mai jos?");
            _dulciuriService.AfisareDulciuri();
            string dulciuriDorite = Console.ReadLine();

            if (_dulciuriService.BuyDulciuri(dulciuriDorite) != false)
            {
                Console.WriteLine("Dulciurile au fost achizitionate cu succes!");
            }
            else
            {
                Console.WriteLine("Dulciurile nu au fost achizitionate");
            }
        }

        public void AddDulce()
        {
            Console.WriteLine("Introduceți gramajul:");
            int gramaj = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduceți prețul total al dulciurilor:");
            int pretdulciuril = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduceți tipul de dulce:");
            string tipDulce = Console.ReadLine();

            Dulciuri dulce6 = new Dulciuri();
            dulce6.pret = pretdulciuril;
            dulce6.tipDulce = tipDulce;
            dulce6.gramaj = gramaj;

            Console.WriteLine("Buchetul a fost adaugat cu succes!");
        }

        public void StergereaUnuiDUlce()
        {
            Console.WriteLine("Din lista de mai jos de dulciuri ce doiriti sa stergeti");
            _dulciuriService.AfisareDulciuri();
            string dulceDorit = Console.ReadLine();

            if (_dulciuriService.FindDulciuriByTipDulce(dulceDorit) != -1)
            {
                _dulciuriService.RemoveDulciuriByDenumire(dulceDorit);
                Console.WriteLine("Dulcele a fost sters!");
            }
            else
            {
                Console.WriteLine("Dulcele nu exista");

            }
        }

        public void EditareDulceDenumire()
        {
            Console.WriteLine("Ce dulce doriti sa modificati");
            string dulceModi = Console.ReadLine();

            Console.WriteLine("Care sa fie noua denumire?");
            string newName = Console.ReadLine();

            int pozitie = _dulciuriService.FindDulciuriByTipDulce(dulceModi);

            if (pozitie != -1)
            {
                if (_dulciuriService.EditDulciuriDenumire(dulceModi, newName))
                {
                    Console.WriteLine("Dulcele a fost modificata cu succes");
                }
                else
                {
                    Console.WriteLine("Dulcele nu a fost modificata");
                }
            }
        }

        public void EditDulciuriPret()
        {
            Console.WriteLine("Ce dulce doriti sa modificati");
            string dulceModi = Console.ReadLine();

            Console.WriteLine("Care sa fie noul pret?");
            int newPrice = Int32.Parse(Console.ReadLine());

            int pozitie = _dulciuriService.FindDulciuriByTipDulce(dulceModi);

            if (pozitie != -1)
            {
                if (_dulciuriService.EditDulciuriPret(dulceModi, newPrice))
                {
                    Console.WriteLine("Dulcele a fost modificata cu succes");
                }
                else
                {
                    Console.WriteLine("Dulcele nu a fost modificata");
                }
            }
        }


    }
}
