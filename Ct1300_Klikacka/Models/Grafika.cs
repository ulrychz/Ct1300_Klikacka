namespace Ct1300_Klikacka.Models
{
    public class Grafika
    {
        public Grafika()
        {
            NahodnePole(radku: 8, sloupcu: 10, cisloOd: 0, cisloDo: 1);
        }
        public Grafika(int pocetBarev, int pocetRadek, int pocetSloupcu)
        {
            PripravBarvy(pocetBarev);
            NahodnePole(radku: pocetRadek, sloupcu: pocetSloupcu, cisloOd: 0, cisloDo: pocetBarev);
        }

        private void PripravBarvy(int pocetBarev)
        {
            for (int i = 0; i <= pocetBarev; i++)
            {
                BarvySeznam.Add(new BunkaBarva(i));
            }
        }

        public Bunka[,] Pole { get; private set; }
        public List<BunkaBarva> BarvySeznam { get; private set; } = new List<BunkaBarva>();

        private int ZvolenaBarva { get; set; } = 2;

        private Random rnd = new Random();

        private void NahodnePole(int radku, int sloupcu, int cisloOd, int cisloDo)
        {
            Pole = new Bunka[radku, sloupcu];
            for (int i = 0; i < radku; i++)
            {
                for (int j = 0; j < sloupcu; j++)
                {
                    Pole[i, j] = new Bunka(rnd.Next(cisloOd, cisloDo + 1), i, j);
                }
            }
        }

        public void OnCellClick(Models.Bunka bunka)
        {
            if (bunka.Hodnota == 0 && bunka.StyleClassIndex != ZvolenaBarva || BarvySeznam.Any())
            {
                bunka.StyleClassIndex = ZvolenaBarva;
            }
            else
                bunka.StyleClassIndex = 0;
        }

        public void OnCellClick(Models.BunkaBarva bunka)
        {
            //for (int i = 0; i < BarvySeznam.Count; i++)
            //{
            //    BarvySeznam[i].Selected = false;
            //}

            foreach (var item in BarvySeznam) 
            { 
                item.Selected = false;
            }

            bunka.Selected = true;
            ZvolenaBarva = bunka.Hodnota;
        }
    }
}
