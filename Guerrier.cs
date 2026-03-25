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
    public bool Attaquer(Personnage cible)
    {
        Console.WriteLine($"\n{nom} attaque {cible.GetNom()} !");
        return cible.RecevoirDegats(20); // Exemple de dégâts infligés
    }
    public override void Afficher()
    {
        Console.WriteLine($"\nGuerrier");
        // On appelle la version du parent pour afficher le Nom et les PV
        base.Afficher(); 
        // On ajoute l'info spécifique
        Console.WriteLine($"Armure : {armure}");
    }
}