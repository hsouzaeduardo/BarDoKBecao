using System;

namespace BarDoKBecao.Entidades
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            Ativo = true;
        }
        public Guid Id { get; set; }
        public DateTime Criacao { get; set; }
        public string Usuario { get; set; }
        public bool Ativo { get; set; }
    
        public virtual void Desativar()
        {
            this.Ativo = false;
        }

    }
}