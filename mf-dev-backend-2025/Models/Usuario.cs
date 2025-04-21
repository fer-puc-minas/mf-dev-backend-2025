using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public Perfil Perfil { get; set; }

    }

    public enum Perfil
    {
        Admin,
        User,
    }
}
