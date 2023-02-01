using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class CheckValidCategoria : ValidationAttribute
    {
        public CheckValidCategoria()
        {
            ErrorMessage = "La categoria solo puede ser desayuno.";
        }

        public override bool IsValid(object value)
        {
            string categoria = (string)value;

            if (categoria == null)
            {
                return false;
            }

            categoria.ToLower();

            if (categoria != "desayuno")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
