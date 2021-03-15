using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
  public  class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(10).When(p => p.BrandId == 1);
            RuleFor(c => c.Descriptions).MinimumLength(2).WithMessage("Car name must be greater than two characters ");
        }
    }
}
