public class Magicien : Personnage
{
    private int puissanceMagique;
    public Magicien(string nom, int pointsDeVie, int puissanceMagique) : base(nom, pointsDeVie)
    {
        this.puissanceMagique = puissanceMagique;
    }
    public int GetPuissanceMagique()
    {
        return puissanceMagique;
    }
    public int SetPuissanceMagique(int puissanceMagique)
    {
        this.puissanceMagique = puissanceMagique;
        return puissanceMagique;
    }
    public void LancerSort(Personnage cible)
    {
        Console.WriteLine($"{this.nom} incante un sort sur {cible.GetNom()} !");
        
        // Les dégâts sont égaux à la puissance magique
        int degats = this.puissanceMagique;
        
        // On applique les dégâts à la cible
        cible.RecevoirDegats(degats);
    }

    public override void Afficher()
    {
        Console.WriteLine($"Magicien");
        base.Afficher(); // Affiche le nom et les points de vie grâce à la méthode du parent
        Console.WriteLine($"Puissance magique : {puissanceMagique}");
    }
}