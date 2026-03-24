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
    // public bool ReductionDegats(int degats)
    // {
    //     int degatsReduits = degats - armure;
    //     if (degatsReduits < 0)
    //     {
    //         degatsReduits = 0;
    //     }
    //     return RecevoirDegats(degatsReduits);
    // }ctl:
    
    public override void Afficher()
    {
        Console.WriteLine($"Guerrier");
        // On appelle la version du parent pour afficher le Nom et les PV
        base.Afficher(); 
        // On ajoute l'info spécifique
        Console.WriteLine($"Armure : {armure}");
    }
}