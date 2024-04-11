namespace Ct1300_Klikacka.Models
{
    public class Bunka
    {
        public Bunka(int hodnota, int radka, int sloupec) 
        { 
            Hodnota = hodnota;
            Radka = radka;
            Sloupec = sloupec;
        }
        public int Hodnota { get; private set; }
        public int Radka { get; private set; }
        public int Sloupec { get; private set; }
        public int StyleClassIndex { get; set; } = 0;
        public virtual string StyleClassName => $"barva-{StyleClassIndex}";
    }
}
