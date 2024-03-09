using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_dulciuri
{
    public class View
    {
         DulciuriService dulciuriService = new DulciuriService();

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate Dulciurile");
            Console.WriteLine("Apsasati tasta 2 ca sa se afiseze toate dulciurile de un anumit gramaj");
            Console.WriteLine("Apasati tasta 3 si introduceti dulciurile pe care le doriti");
            Console.WriteLine("Apasati tasta 4 pentru adauga un produs dulce nou");
        }

        public void Play()
        {
            bool running = true;
            dulciuriService.LoadData();

            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        dulciuriService.AfisareDulciuri();
                        break;
                }
            }
        }
    }
}
