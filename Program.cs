namespace tp_personnages;

class Program
{
    static void Main(string[] args)
    {
        Personnage p1 = new Personnage("son gohan", 100);
        Console.WriteLine(p1.GetNom());
        Console.WriteLine(p1.GetPointsDeVie());
        p1.RecevoirDegats(30);
        Personnage p2 = new Personnage("trunks", 80);
        Console.WriteLine(p2.GetNom());
        Console.WriteLine(p2.GetPointsDeVie());
        p2.RecevoirDegats(50);

    }
}
// 172.25.254.24
// 3128