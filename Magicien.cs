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

    public override void Afficher()
    {
        base.Afficher(); // Affiche le nom et les points de vie grâce à la méthode du parent
        Console.WriteLine($"Puissance magique : {puissanceMagique}");
    }
}