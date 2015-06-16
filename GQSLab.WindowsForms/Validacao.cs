using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace GQSLab.WindowsForms
{
    public static class Validacao
    {
        public static IEnumerable<ValidationResult> GetValidationErrors(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);

            // Determina se o objeto especificado é válido
            //var isValid = Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            
            return resultadoValidacao;
        }        
    }
}
