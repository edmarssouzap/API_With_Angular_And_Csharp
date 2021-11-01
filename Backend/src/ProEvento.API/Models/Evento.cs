using System; // Using usado pelo DateTime?


namespace ProEvento.API.Models
{
    public class Evento
    {
        public int EventoId {get; set; }
        public string Local { get; set; }
        // ? permite que um campo seja not null
        public DateTime? DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemUrl { get; set; }
    }
}