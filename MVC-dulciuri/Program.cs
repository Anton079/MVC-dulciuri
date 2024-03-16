using MVC_dulciuri;

internal class Program
{
    public static void Main(string[] args)
    {
        DulciuriService service = new DulciuriService();

        service.LoadData();

        Dulciuri dulciuri = new Dulciuri();
        dulciuri.gramaj = 100;
        dulciuri.tipDulce = "Mentosane";
        dulciuri.pret = 10;
        bool t = service.AddDulciuriinList(dulciuri);
        Console.WriteLine(t);

        service.AfisareDulciuri();

    }
}