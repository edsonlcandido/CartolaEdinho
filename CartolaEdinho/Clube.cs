using System.Text.Json.Serialization;

namespace CartolaEdinho
{
    public class Clube
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? abreviacao { get; set; }
        public string? nome_fantasia { get; set; }

        //prorpiedade adicionada por mim
        public bool mandante { get; set; }
        public bool melhor { get; set; }
        public string? confronto { get; set; }
        public double? multiplicador { get; set; }
        public int? posicao { get; set; }
    }
}
