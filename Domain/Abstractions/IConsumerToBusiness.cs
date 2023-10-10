using Domain.Entities;

namespace Domain.Abstractions
{
    public interface IConsumerToBusiness
    {
        void Insert(ConsumerToBusiness consumerToBusiness);
    }
}
