using APIReact.ViewModel.Paging;

namespace APIReact.ViewModel.Employee
{
    public class CustomerPaging : PagingRequestBase
    {
        public string Keyword { get; set; } = string.Empty;
    }
}
