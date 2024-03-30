namespace APIReact.ViewModel.Paging
{
    public class PagedResult<T> : PagedResutBase
    {
        public List<T> item { get; set; }
    }
}
