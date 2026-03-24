using System.Reflection.Metadata.Ecma335;

public class Personnage
{
    private string nom;
    private int pointsDeVie;
    public Personnage(string nom, int pointsDeVie)
    {
        this.nom = nom;
        this.pointsDeVie = pointsDeVie;
    }
    public string GetNom()
    {
        return nom;
    }
    public int GetPointsDeVie()
    {
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




}
