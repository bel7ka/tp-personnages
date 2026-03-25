public class Archer : Personnage
{
    private int precision;
    public Archer(string nom, int pointsDeVie, int precision) : base(nom, pointsDeVie)
    {
        this.precision = precision;
    }
    public int GetPrecision()
    {
        return precision;
    }
    public int SetPrecision(int precision)
    {
        this.precision = precision;
        return precision;
    }

    // public void TirerFleche(Personnage cible)
    // {
    //     Console.WriteLine($"L’archer tire une flèche avec une précision de {precision}");
    //     Console.WriteLine($"\n{this.nom} tire une flèche sur {cible.GetNom()} !");

    //     // Les dégâts sont égaux à la précision
    //     int degats = this.precision;
        
    //     // On applique les dégâts à la cible
    //     cible.RecevoirDegats(degats);
    // }

    public override void Afficher()
    {
        Console.WriteLine($"\nArcher");
        base.Afficher(); // Affiche le nom et les points de vie grâce à la méthode du parent
        Console.WriteLine($"Précision : {precision}");
    }
    public override string ToString()
    {
        return $"[Archer] Nom : {nom}, Points de vie : {pointsDeVie}, précision : {precision}";
    }
}