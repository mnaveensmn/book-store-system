using BookStore.Api.Application.Usecase;
using BookStore.Api.Domain.Entities;

namespace BookStore.Api.Infrastructure.Usecase;

public class GetBooksRepository : IGetBooksRepository
{
    public IEnumerable<Book> GetByPage(int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }
}