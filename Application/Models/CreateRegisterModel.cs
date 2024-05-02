using atmservice.Domain.Entity;
using FluentValidation;

namespace atmservice.Application.Models
{
    public class CreateRegisterModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    
     public class CrRegister : AbstractValidator<LoginInfo>
    {
        public CrRegister()
        {
            RuleFor(a => a.UserName).MaximumLength(50).MinimumLength(5).WithMessage("The UserName must be between 5 to 50");;
            RuleFor(a => a.Password).MaximumLength(50).MinimumLength(8).WithMessage("The Password must be between 8 to 50");
            
        }   
    }
}