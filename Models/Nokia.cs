namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string _modelo, string _imei, int _memoria) : base(numero, _modelo, _imei, _memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando o app \"{nomeApp}\" no smartphone Nokia");
        }
    }
}