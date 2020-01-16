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
            string ErrorMessage;
            float PersonalBest = 0;
            int Helper = 0;
            if (validationContext.DisplayName == null)
                ErrorMessage = "Personal Best is incorrect";
            if (value == null)
                return ValidationResult.Success;
            if (value is float)
                PersonalBest = (float)value;
            else
                return new ValidationResult("The type of Personal Best must be float");
            if (PersonalBest < 0)
                return new ValidationResult("Personal best cannot be lower than 0");
            if (PersonalBest > 300)
                return new ValidationResult("If jumper who jump over 300 meters is still alive i will crash my head");
            Helper = (int)PersonalBest;
            if (Math.Abs(PersonalBest - Helper) != 0 && Math.Abs(PersonalBest - Helper) != 0.5)
                return new ValidationResult("In skijumping pattern of meter result is x.0 or x.5 only");
            return ValidationResult.Success;
        }
    }
}
