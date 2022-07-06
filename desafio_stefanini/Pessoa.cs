using System.ComponentModel.DataAnnotations;

namespace desafio_stefanini
{
    public class Pessoa
    {
        public int Id { get; set; }

        [StringLength(300)]
        public string Nome { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }   

        public int Idade { get; set; }  

    }
}
