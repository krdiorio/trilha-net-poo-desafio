namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string EMEI { get; set; }
        protected int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string emei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            EMEI = emei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}