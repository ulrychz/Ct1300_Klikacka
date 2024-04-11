namespace Ct1300_Klikacka.Models
{
    public class BunkaBarva : Bunka
    {
        public BunkaBarva(int sloupec) : base(hodnota: sloupec, radka: 0, sloupec)
        {
            StyleClassIndex = sloupec;
        }
        public bool Selected { get; set; } = false;
        private string StyleClassNameSelected => Selected ? "selected" : "";
        public override string StyleClassName => $"barva-{StyleClassIndex} {StyleClassNameSelected}";
    }
}
