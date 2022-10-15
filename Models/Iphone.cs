namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string emei, int memoria) : base(numero, modelo, emei, memoria)
        { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.Write($"Instalando aplicativo {nomeApp} no celular Iphone");
        }
    }
}