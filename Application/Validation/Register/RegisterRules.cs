using atmservice.Domain.Entity;
using FluentValidation;

namespace atmservice.Application.Validation.Register
{
    public class RegisterRules : AbstractValidator<Expert>
    {
        public RegisterRules()
        {
            RuleFor(a => a.FullName).NotNull();
        }
    }
}