namespace SuiteDeFibonacciConsole;
public class SuiteDeFibonacci
{
    public void lancer(int max)
    {
        RetournerCalcule(0, 0, 1, max);
    }

    public void RetournerCalcule(int incrementStop, int nombreUn, int nombreDeux, int max)
    {
        int resultat = nombreUn + nombreDeux;
        Console.WriteLine(resultat);

        nombreUn = nombreDeux;
        nombreDeux = resultat;
        incrementStop++;
        bool estArret = (incrementStop != max);
        if (estArret)
            RetournerCalcule(incrementStop, nombreUn, nombreDeux, max);
    }
}
