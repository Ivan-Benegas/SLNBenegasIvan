using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class CheckValidEdad : ValidationAttribute
    {
        public CheckValidEdad()
        {
            ErrorMessage = "El autor debe tener 18 años en adelante.";
        }

        public override bool IsValid(object value)
        {
            int edad = (int)value;

            if (edad < 18)
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
