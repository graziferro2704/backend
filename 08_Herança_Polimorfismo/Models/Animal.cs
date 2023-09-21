namespace Sesi.Models

{
    public class Animal
    {
        public string cor { get; set; }
        public string especie { get; set; }
        public decimal peso { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Emitindo som");
        }
    }


}