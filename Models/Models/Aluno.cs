using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroAlunosMVC.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "E-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "RA é obrigatório")]
        public string RA { get; set; }

        [Required(ErrorMessage = "Curso é obrigatório")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatória")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}
