using System.ComponentModel.DataAnnotations;

namespace desafio_stefanini
{
    public class Cidade
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Nome { get; set; }

        [StringLength(2)]
        public string UF { get; set; }  

    }
}
