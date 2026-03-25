using System.Linq.Expressions;

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
        p2.RecevoirDegats(50,30);

        int armure = 15;
        Guerrier g1 = new Guerrier("Arthur", 120, armure);
        g1.Afficher(); // Appellera la version Guerrier grâce à 'override'
        g1.Attaquer(p1); // Arthur attaque Son Gohan
        g1.RecevoirDegats(50,30);

        Magicien m1 = new Magicien("Merlin", 90, 50);
        m1.Afficher(); // Appellera la version Magicien grâce à 'override'
        m1.LancerSort(g1); // Merlin lance un sort sur Arthur
        List<Personnage> persos = new List<Personnage>();
        Personnage g2 = new Guerrier("Lancelot", 110, 20);
        persos.Add(g2);
        Personnage m2 = new Magicien("Morgane", 85,40);
        persos.Add(m2);
        foreach (Personnage p in persos)
        {
            p.Afficher(); // Appellera la version appropriée grâce au polymorphisme
        }
    }
}

// 172.25.254.24
// 3128