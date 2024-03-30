
using APIReact;
using APIReact.ViewModel.Employee;
using APIReact.ViewModel.Paging;
using Microsoft.EntityFrameworkCore;

namespace APIToReact.ApiService
{
    public class ApiService : IAPiService
    {
        private readonly CustomerDbContext _context;
        public ApiService(CustomerDbContext context) {
            _context = context;
        }

        public async Task<PagedResult<CustomerViewModel>> GetAllPage(CustomerPaging request)
        {
            var query = from p in _context.Customer select new { p };
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x=>x.p.CustomerId.Contains(request.Keyword) || x.p.CompanyName.Contains(request.Keyword));
            }
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex -1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x=> new CustomerViewModel()
                {
                    CustomerId = x.p.CustomerId,
                    CompanyName = x.p.CompanyName,
                    ContactName = x.p.ContactName,
                    ContactTitle = x.p.ContactTitle,
                    Address = x.p.Address,
                    City = x.p.City,
                    Region = x.p.Region,
                    Country = x.p.Country,
                    Phone = x.p.Phone,
                    Fax = x.p.Fax,
                }).ToListAsync();

            var pagedView = new PagedResult<CustomerViewModel>()
            {
                TotalRecord = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                item = data
            };
            return pagedView;
        }

       
    }
}
