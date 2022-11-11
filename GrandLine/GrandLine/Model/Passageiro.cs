using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrandLine.Model
{
    [Table("passageiros")]
    public class Passageiro
    {
        [Key]
        public int PassageiroId { get; set; }
        [Required(ErrorMessage = "Informe o id do passageiro")]
        [StringLength(50)]

        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o nome do passageiro")]


        public string Email { get; set; }
        [Required(ErrorMessage = "Informe um email para passageiro")]


        public date DataNascimento { get; set; }
        [Required(ErrorMessage = "Informe uma data de nascimento para passageiro")]

       
    }
}
