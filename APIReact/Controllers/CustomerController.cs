
using APIReact.ViewModel.Employee;
using APIToReact.ApiService;
using Microsoft.AspNetCore.Mvc;

namespace APIReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IAPiService _apiService;
        public CustomerController(IAPiService apiService) {
            _apiService = apiService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomerPage([FromQuery] CustomerPaging request)
        {
            var customer = await _apiService.GetAllPage(request);
            return Ok(customer);
        }
    }
}
