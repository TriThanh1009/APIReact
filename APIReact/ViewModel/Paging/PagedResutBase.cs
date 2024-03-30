namespace APIReact.ViewModel.Paging
{
    public class PagedResutBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalRecord { get; set; }
        public int PageCount
        {
            get
            {
                var pagecount = (double)TotalRecord / PageSize;
                return (int)Math.Ceiling(pagecount);
            }
        }
    }
}

