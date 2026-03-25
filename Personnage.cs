using System.Reflection.Metadata.Ecma335;

public class Personnage
{
    protected string nom;
    protected int pointsDeVie;
    public Personnage(string nom, int pointsDeVie)
    {
        this.nom = nom;
        this.pointsDeVie = pointsDeVie;
    }
    public string GetNom()
    {
        return nom;
    }
    public string SetNom(string nom)
    {
        this.nom = nom;
        return nom;
    }
    public int GetPointsDeVie()
    {
        return pointsDeVie;
    }
    public int SetPointsDeVie(int pointsDeVie)
    {
        this.pointsDeVie = pointsDeVie;
        return pointsDeVie;
    }
    
    bool vivant = true;
    public bool RecevoirDegats(int degats)
    {
        if(!vivant)
        {
            Console.WriteLine($"{nom} est déjà vaincu et ne peut pas subir de nouveaux dégâts !");
            return false; // Le personnage est déjà vaincu, il ne peut pas subir de nouveaux dégâts
        }
        pointsDeVie -= degats;
        if (pointsDeVie <= 0)
        {
            pointsDeVie = 0;
            Console.WriteLine($"{nom} a recu {degats} dégâts et a été vaincu !");
            return vivant = false;
        }
        else
        {
            Console.WriteLine($"{nom} a pris {degats} dégâts et a {pointsDeVie} points de vie restants .");
            return vivant = true;
        }
    }
    public bool RecevoirDegats(int degats, int reduction)
    {
        if(!vivant)
        {
            Console.WriteLine($"{nom} est déjà vaincu et ne peut pas subir de nouveaux dégâts !");
            return false; // Le personnage est déjà vaincu, il ne peut pas subir de nouveaux dégâts
        }
        int degatsReels = degats - reduction;
        if (degatsReels < 0) degatsReels = 0; // On ne veut pas soigner le perso !
        
        Console.WriteLine($"(Degats: {degats} - Réduction de {reduction} activée !)");
        
        // On appelle la version 1 pour appliquer les dégâts finaux
        return RecevoirDegats(degatsReels); 
    }
    public virtual void Afficher()
    {
        Console.WriteLine($"\n[Perso] Nom : {nom}, Points de vie : {pointsDeVie}");
    }
    
    public override string ToString()
    {
        return $"[Personnage] Nom : {nom}, Points de vie : {pointsDeVie}";
    }
}
