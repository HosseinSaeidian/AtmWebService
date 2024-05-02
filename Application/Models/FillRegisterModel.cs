using atmservice.Domain.Entity;
using FluentValidation;

namespace atmservice.Application.Models
{

    public class FillRegisterModel
    {
       public string? FullName { get; set; }
        public string? FatherName { get; set; }
        public string? NathionalCode { get; set; }
        public string? Email { get; set; }


        public string? AccountNumber { get; set; }
        public string? AccountOwner { get; set; }
        public string? BankName { get; set; }

    }
 

    public class RegisterRules : AbstractValidator<Register>
    {
        public RegisterRules()
        {
            RuleFor(a => a.FullName).MaximumLength(50).MinimumLength(5).WithMessage("The FullName must be between 5 to 50");;
            RuleFor(a => a.FatherName).MaximumLength(20).MinimumLength(1).WithMessage("The FatherName must be between 1 to 20");
            RuleFor(a => a.NathionalCode).Length(10).WithMessage("The national code must be 10 digits");
            RuleFor(a => a.Email).MaximumLength(200).WithMessage("Field Email have problem");
            RuleFor(a => a.AccountNumber).Length(16).WithMessage("The AccountNumber must be 16 digits");
            RuleFor(a => a.AccountOwner).MaximumLength(50).MinimumLength(5).WithMessage("The Accountowner must be Max 50 and minimum 5 digits");;
            RuleFor(a => a.BankName).MaximumLength(50).MinimumLength(2).WithMessage("The Bankname must be Max 50 and minimum 2 digits");;
        }   
    }
}