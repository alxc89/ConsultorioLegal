using System;

namespace src.api.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public string Telefone { get; set; }
        public string Documento { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime? UltimaAlteracao { get; set; }
    }
}