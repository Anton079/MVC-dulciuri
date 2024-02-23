using MVC_dulciuri;

internal class Program
{
    public static void Main(string[] args)
    {
        DulciuriService service = new DulciuriService();

        service.LoadData();

        service.AfisareDulciuri();
    }
}