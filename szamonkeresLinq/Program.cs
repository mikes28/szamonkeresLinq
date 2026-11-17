using Org.BouncyCastle.Security;
using szamonkeresLinq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Szorny> szornyek = new List<Szorny>();
        szornyek = SzornyAdatbazis.Feltolt();


        SzornyElemzo szornyekElemzo= new(szornyek);

        //all linq queries are called here and the results are printed to the console
        
        Console.WriteLine($"Összes szörny száma: {szornyekElemzo.OsszesSzornySzama()}");

        Console.WriteLine("Veszélyes szörnyek nevei:");
        foreach (var szorny in szornyekElemzo.VeszelyesSzornyekNevei())
        {
            Console.WriteLine(szorny.Nev);
        }

        Console.WriteLine("Egyedi élőhelyek:");
        foreach (var elohely in szornyekElemzo.EgyediElohelyek())
        {
            Console.WriteLine(elohely);
        }
        Console.WriteLine($"Átlagos veszélyességi szint: {szornyekElemzo.AtlagosVeszelyesseg()}");
        Console.WriteLine("Legveszélyesebb szörnyek:");
        foreach (var szorny in szornyekElemzo.LegveszelyesebbSzornyek())
        {
            Console.WriteLine($"{szorny.Nev} - Veszélyességi szint: {szorny.VeszelyessegiSzint}");
        }
        Console.WriteLine("Mocsári veszélyes szörnyek:");
        foreach (var szorny in szornyekElemzo.MocsariVeszelyesSzornyek())
        {
            Console.WriteLine($"{szorny.Nev} - Élőhely: {szorny.Elohely} - Veszélyességi szint: {szorny.VeszelyessegiSzint}");
        }
        Console.WriteLine($"Van-e extrém tűz gyenge szörny? {(szornyekElemzo.VanExtremTuzGyengeSzorny() ? "Igen" : "Nem")}");
        Console.WriteLine("Szörnyek száma élőhelyenként:");
        foreach (var elohely in szornyekElemzo.SzornyekSzamaElohelyenkent())
        {
            Console.WriteLine(elohely);
        }
        Console.WriteLine("A program véget ért. Nyomj meg egy gombot a kilépéshez.");



    }
}