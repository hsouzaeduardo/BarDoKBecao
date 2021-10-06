using System;

namespace BarDoKBecao.Entidades
{
    public class Cliente : BaseEntity
    {
        public string Cpf{ get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public short Idade { get; set; } 
    }
}