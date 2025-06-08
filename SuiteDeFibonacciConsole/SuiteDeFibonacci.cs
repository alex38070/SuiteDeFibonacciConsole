namespace SuiteDeFibonacciConsole;
public class SuiteDeFibonacci
{
    public SuiteDeFibonacci()
    {

    }

    public static void lancer()
    {
        SuiteDeFibonacci.RetournerCalcule(0, 0, 1);
    }

    public static void RetournerCalcule(int incrementStop, int nombreUn, int nombreDeux)
    {
        int resultat = nombreUn + nombreDeux;
        Console.WriteLine(resultat);

        nombreUn = nombreDeux;
        nombreDeux = resultat;
        incrementStop++;
        bool estArret = (incrementStop != 20);
        if (estArret)
            SuiteDeFibonacci.RetournerCalcule(incrementStop, nombreUn, nombreDeux);
    }
}
