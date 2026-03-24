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
        pointsDeVie -= degats;
        if (pointsDeVie <= 0)
        {
            pointsDeVie = 0;
            Console.WriteLine($"{nom} a été vaincu !");
            return vivant = false;
        }
        else
        {
            Console.WriteLine($"{nom} a pris {degats} dégâts et a {pointsDeVie} points de vie restants .");
            return vivant = true;
        }
    }
    public virtual void Afficher()
    {
        Console.WriteLine($"[Perso] Nom : {nom}, Points de vie : {pointsDeVie}");
    }
    

}
