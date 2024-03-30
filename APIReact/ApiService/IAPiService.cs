using APIReact.ViewModel.Employee;
using APIReact.ViewModel.Paging;

namespace APIToReact.ApiService
{
    public interface IAPiService
    {
        Task<PagedResult<CustomerViewModel>> GetAllPage(CustomerPaging request);
    }
}
