using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteEtec.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome.")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres.")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public string Foto { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public bool ExibirHome { get; set; }

        //quando quiser criar um objeto que nao existe no banco, apenas para efeito de programação
        // é criado uma anotacao
        //[NotMapped]
        //public int MyPropierty { get; set; }
    }
}