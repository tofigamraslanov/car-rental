using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator<T> : AbstractValidator<CarImageDto>
    {
        public CarImageValidator()
        {
            RuleFor(x => x.ImageFile).NotNull().WithMessage("File field cannot be empty.");

            RuleFor(x => x.ImageFile.ContentType).NotNull().Must(x => x.Equals("image/jpeg") || x.Equals("image/jpg") || x.Equals("image/png"))
               .WithMessage("Type of the file is not supported!");
        }
    }

    public class AddCarImageValidator : CarImageValidator<CarImageDto>
    {
        public AddCarImageValidator()
        {
            RuleFor(x => x.CarId).GreaterThan(0).WithMessage("CarId cannot be empty.");
        }
    }

    public class UpdateCarImageValidator : CarImageValidator<CarImageDto>
    {
        public UpdateCarImageValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id cannot be empty.");
        }
    }
}