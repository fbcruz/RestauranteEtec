using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteEtec.Models
{
    [Table("Reserva")]
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres.")]
        public string NomePessoa { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "Por favor, informe seu Celular.")]
        [StringLength(20, ErrorMessage = "O Celular deve possuir no máximo 20 caracteres.")]
        public string FonePessoa { get; set; }

        [Display(Name = "Data da Reserva")]
        [Required(ErrorMessage = "Por favor, a data da reserva.")]
        public DateTime DataReserva { get; set; }

        public byte Convidados { get; set; }
        public DateTime DataCadastro { get; set; }
        public byte status { get; set; }

    }
}