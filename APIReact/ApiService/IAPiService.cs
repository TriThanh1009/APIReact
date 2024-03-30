namespace APIToReact.ApiService
{
    public interface IAPiService
    {
        Task GetApi();
        Task GetCustomerByID(string id);
        Task GetCustomerByName(string name);
    }
}
