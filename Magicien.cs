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
    
    public void Afficher()
    {
        Console.WriteLine($"Nom : {nom}, Points de vie : {pointsDeVie}, Puissance magique : {puissanceMagique}");
    }
}