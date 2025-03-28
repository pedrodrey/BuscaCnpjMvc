using BuscaCnpjMvc.Models;

namespace BuscaCnpjMvc.Services.Interfaces
{
    public interface ICnpjService
    {
        Task<CnpjResponse> ObterCnpjAsync(string cnpj);
        Task<CnpjResponse> SalvarCnpjAsync(CnpjResponse cnpjResponse);
    }
}
