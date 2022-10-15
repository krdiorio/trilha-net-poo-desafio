namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string emei, int memoria) : base(numero, modelo, emei, memoria)
        { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.Write($"Instalando aplicativo {nomeApp} no celular Nokia");
        }
    }
}