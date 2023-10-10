using FluentValidation;

namespace Application.ConsumerToBusiness.Commands
{
    public sealed class CreateVoucherLogCommandValidator : AbstractValidator<CreateConsumerToBusinessCommand>
    {
        public CreateVoucherLogCommandValidator()
        {

        }
    }
}
