using Domain.Abstractions;
using Domain.Entities;
using Infrastructure.Database;

namespace Infrastructure.Repositories
{
    public class ConsumerToBusinessRepository : IConsumerToBusiness
    {
        private readonly ApplicationDbContext _dbContext;

        public ConsumerToBusinessRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public void Insert(ConsumerToBusiness consumerToBusiness) => _dbContext.Set<ConsumerToBusiness>().Add(consumerToBusiness);
    }
}
