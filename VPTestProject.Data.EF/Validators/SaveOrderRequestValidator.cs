using FluentValidation;
using VPTestProject.Data.EF.Requests;

namespace VPTestProject.Data.EF.Validators
{
    public sealed class SaveOrderRequestValidator : AbstractValidator<SaveOrderRequest>
    {
        public SaveOrderRequestValidator()
        {
            RuleFor(x => x.Products).NotEmpty();
            RuleFor(x => x.TotalPrice).NotEmpty();
        }
    }
}
