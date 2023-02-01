using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaWebMisRecetas.Validations;

namespace SistemaWebMisRecetas.Models
{

    [Table("Receta")]
    public class Receta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        [CheckValidCategoria]
        public string Categoria { get; set; }

        [Required]
        public string Ingredientes { get; set; }

        [Required]
        public string Instrucciones { get; set; }

        [Required]
        public string AutorNombre { get; set; }

        [Required]
        public string AutorApellido { get; set; }

        [Required]
        [CheckValidEdad]
        public int AutorEdad { get; set; }

        [Required]
        [EmailAddress]
        public string AutorEmail { get; set; }

    }
}
