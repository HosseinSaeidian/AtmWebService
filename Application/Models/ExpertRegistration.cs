using atmservice.Domain.Entity;
using FluentValidation;

namespace atmservice.Application.Models
{

    public class ExpertRegistration
    {
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string NathionalCode { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
 

    public class RegisterRules : AbstractValidator<Expert>
    {
        public RegisterRules()
        {
            RuleFor(a => a.FullName).NotNull().MaximumLength(50).MinimumLength(5).WithMessage("The FullName must be between 5 to 50");;
            RuleFor(a => a.FatherName).NotNull().MaximumLength(20).MinimumLength(1).WithMessage("The FatherName must be between 1 to 20");
            RuleFor(a => a.NathionalCode).NotNull().Length(10).WithMessage("The national code must be 10 digits");
            RuleFor(a => a.Email).NotNull().MaximumLength(100).WithMessage("Field Email have problem");
            RuleFor(a => a.UserName).NotNull().MaximumLength(30).MinimumLength(5).WithMessage("The UserName must be Max 30 digits");
            RuleFor(a => a.Password).NotNull().MaximumLength(30).MinimumLength(8).WithMessage("The Passwrod must be Max 30 digits");;
        }   
    }
}