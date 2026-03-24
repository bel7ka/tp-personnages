namespace tp_personnages;

class Program
{
    static void Main(string[] args)
    {
        Personnage p1 = new Personnage("son gohan", 100);
        p1.Afficher();
        p1.RecevoirDegats(30);
        Personnage p2 = new Personnage("trunks", 80);
        p2.Afficher();
        p2.RecevoirDegats(50);
        Guerrier g1 = new Guerrier("Ichigo", 120, 15);
        g1.Afficher(); // Appellera la version Guerrier grâce à 'override'
        Magicien m1 = new Magicien("Merlin", 90, 50);
        m1.Afficher(); // Appellera la version Magicien grâce à 'override'
        


    }
}

// 172.25.254.24
// 3128