public class Guerrier : Personnage
{
    public int armure;

    public Guerrier(string nom, int pointsDeVie, int armure) : base(nom, pointsDeVie)
    {
        this.armure = armure;
    }
    public int GetArmure()
    {
        return armure;
    }
    public int SetArmure(int armure)
    {
        this.armure = armure;
        return armure;
    }
    public bool ReductionDegats(int degats)
    {
        int degatsReduits = degats - armure;
        if (degatsReduits < 0)
        {
            degatsReduits = 0;
        }
        return RecevoirDegats(degatsReduits);
    }
    public void Afficher()
    {
        Console.WriteLine($"[Guerrier] Nom : {nom}, Points de vie : {pointsDeVie}, Armure : {armure}");
    }
}