public class Otomobil
{
    public string Renk;
    public short ModelYili;
    //.....
    public Motor mtr = new Motor(); //compısıtıon
    public RadyoTeyp rt; //Aggregation
}

public class Motor
{
    public short Hacim;
    public string YakitTürü;
}

public class RadyoTeyp
{
    public bool Bluetooth;
    //.....
}

class Program
{
    static void Main(string[] args)
    {
        RadyoTeyp rt1 = new RadyoTeyp();
        rt1.Bluetooth = true;

        Otomobil oto1 = new Otomobil();
        Otomobil oto2 = new Otomobil();

        oto1.rt = rt1;
        oto2.rt = rt1;
        Console.ReadKey();
    }
}
