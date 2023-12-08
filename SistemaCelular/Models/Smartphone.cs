namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; private set; }
        public string Imei { get; private set; }
        public int Memoria { get; private set; }

        protected Smartphone()
        {
        }

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
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
        public void addModelo(string modelo)
        {
            Modelo = modelo;
        }
        public void addImei(string imei)
        {
            Imei = imei;
        }
        public void addMemoria(int memoria)
        {
            Memoria = memoria;
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}