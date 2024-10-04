namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private  int Memoria{get;set;}
        private  string IMEI{get;set;}
        private  string Modelo{get;set;}
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero,int memoria,string imei,string modelo)
        {
            Numero = numero;
            Memoria = memoria;
            Modelo = modelo;
            IMEI = imei;
            // TODO: Passar os parâmetros do construtor para as propriedades
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
