using Application.Abstractions.Messaging;
using Application.EventBus.Models;

namespace Application.ConsumerToBusiness.Commands
{
    public sealed record CreateConsumerToBusinessCommand(string TransactionType, string TransId, string TransTime, string TransAmount, string BusinessShortCode, string BillRefnumber, string InvoiceNumber, string Orgaccountbalance, string ThirdPartyTransID, string Msisdn, string FirstName, string MiddleName, string LastName) : ICommand<ConsumerToBusinessResponse>;
}
