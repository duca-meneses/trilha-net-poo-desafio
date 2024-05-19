namespace DesafioPOO.Models;

public abstract class Smartphone
{
    public Smartphone(string numero, string _modelo, string _imei, int _memoria)
    {
        Numero = numero;
        modelo = _modelo;
        imei = _imei;
        memoria = _memoria;
    }
    public string Numero { get; set; }
    // TODO: Implementar as propriedades faltantes de acordo com o diagrama
    private string modelo;
    private string imei;
    private int memoria;

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