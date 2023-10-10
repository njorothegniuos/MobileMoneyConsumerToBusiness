using Application.Abstractions.Messaging;
using Application.EventBus;
using Application.EventBus.Models;

namespace Application.ConsumerToBusiness.Commands
{
    public class CreateConsumerToBusinessHandler : ICommandHandler<CreateConsumerToBusinessCommand, ConsumerToBusinessResponse>
    {
        private readonly IEventBus _eventBus;
        public CreateConsumerToBusinessHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public async Task<ConsumerToBusinessResponse> Handle(CreateConsumerToBusinessCommand request, CancellationToken cancellationToken)
        {
            await _eventBus.PublishAsync(new ConsumerToBusinessReceivedEvent
            {
                TransactionType = request.TransactionType,
                TransID = request.TransId,
                TransTime = request.TransTime,
                TransAmount = request.TransAmount,
                BusinessShortCode = request.BusinessShortCode,
                BillRefNumber = request.BillRefnumber,
                InvoiceNumber = request.InvoiceNumber,
                OrgAccountBalance = request.Orgaccountbalance,
                ThirdPartyTransID = request.ThirdPartyTransID,
                MSISDN = request.Msisdn,
                FirstName = request.FirstName,
                MiddleName = request.MiddleName,
                LastName = request.LastName,
                CreatedAt = DateTime.UtcNow
            }, cancellationToken);

            return new ConsumerToBusinessResponse { ResultCode="0", ResultDesc="Successful" };
        }
    }
}
