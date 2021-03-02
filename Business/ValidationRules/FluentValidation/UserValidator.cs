using Core.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            //RuleFor(u => u.PasswordHash[]).MinimumLength(8);
            RuleFor(u => u.Email).Must(ContainsAt).WithMessage("Email invalid");
        }

        private bool ContainsAt(string arg)
        {
            return arg.Contains("@");
        }
    }
}
