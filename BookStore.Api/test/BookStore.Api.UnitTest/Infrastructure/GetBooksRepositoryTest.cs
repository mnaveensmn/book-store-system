using BookStore.Api.Application.Usecase;
using BookStore.Api.Infrastructure.Usecase;

namespace BookStore.Api.UnitTest.Infrastructure;

public class GetBooksRepositoryTest
{
    private IGetBooksRepository _getBooksRepository = new GetBooksRepository();

    public void GetByPage_GivePageNumberAndPageSize_ReturnsPagedBookList()
    {
        _getBooksRepository.GetByPage(1, 10);
    }
}