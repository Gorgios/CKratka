using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SkijumpingTeams.Validators
{
    public class IsResult : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public float Result { get; private set; }

        public IsResult()
        {
            Result = 0.01F;
        }
        public IsResult(float result)
        {
            Result = result;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }
    }
}
