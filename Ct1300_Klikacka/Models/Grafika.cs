namespace Ct1300_Klikacka.Models
{
    public class Grafika
    {
        public Grafika()
        {
            NahodnePole(radku: 8, sloupcu: 10, cisloOd: 0, cisloDo: 1);
        }
        public Bunka[,] Pole { get; private set; }

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
            if (bunka.Hodnota == 0 && bunka.StyleClassIndex != ZvolenaBarva)
            {
                bunka.StyleClassIndex = ZvolenaBarva;
            }
            else
                bunka.StyleClassIndex = 0;
        }
    }
}
