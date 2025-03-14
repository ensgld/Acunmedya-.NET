namespace Homework2;

public class Araba
{
    public string marka { get; set; }
    public double yakitTuketimi { get; set; }
    public double gidilenMesafe { get; set; }

    
    public Araba(string marka, double yakitTuketimi, double gidilenMesafe)
    {
        this.marka = marka;
        this.yakitTuketimi = yakitTuketimi;
        this.gidilenMesafe = gidilenMesafe;
    }

    
    public double BenzinTuketimiHesapla()
    {
        return (yakitTuketimi * gidilenMesafe) / 100;
    }
    
}