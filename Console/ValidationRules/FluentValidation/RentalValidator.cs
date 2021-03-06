using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.ReturnDate).NotEmpty();
            RuleFor(r => r.RentDate).GreaterThanOrEqualTo(DateTime.Today);
            RuleFor(r => r.ReturnDate).GreaterThanOrEqualTo(r => r.RentDate);
        }

  
    }
}
