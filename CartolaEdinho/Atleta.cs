﻿using System.Text.Json.Serialization;

namespace CartolaEdinho
{
    public class Atleta
    {
        public int atleta_id { get; set; }
        public int clube_id { get; set; }
        public int posicao_id { get; set; }
        public double? pontos_num { get; set; }
        public double? preco_num { get; set; }
        public double? variacao_num { get; set; }
        public double? media_num { get; set; }
        public double? minimo_para_valorizar { get; set; }
        public string slug { get; set; }
        public string apelido { get; set; }
        public string nome { get; set; }
        public int? jogos_num { get; set; }
        public int status_id { get; set; }
        public Scout scout { get; set; }
        public GatoMestre gato_mestre { get; set; }
    }
}
