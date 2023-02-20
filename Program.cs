internal class Program
{
    private static void Main(string[] args)
    {
        int a = 2;
        int b = 3;

        int sonuc = topla(a,b);
        Console.WriteLine(sonuc);

        metotlar ornek = new metotlar();
        ornek.yazdir(Convert.ToString(sonuc));

    }
    static int topla(int deger1, int deger2)
    {
        return(deger1+deger2);
    }
}
class metotlar
{
    public void yazdir(string veri)
    {
        Console.WriteLine(veri);
    }
}