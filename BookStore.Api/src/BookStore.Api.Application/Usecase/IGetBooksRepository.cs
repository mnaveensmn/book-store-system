using BookStore.Api.Domain.Entities;

namespace BookStore.Api.Application.Usecase;

public interface IGetBooksRepository
{
    public IEnumerable<Book> GetByPage(int pageNumber, int pageSize);
}