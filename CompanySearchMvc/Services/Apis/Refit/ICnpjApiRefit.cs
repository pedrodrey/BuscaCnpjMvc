using BuscaCnpjMvc.Models;
using Refit;

namespace BuscaCnpjMvc.Services.Apis.Refit
{
    public interface ICnpjApiRefit
    {
        [Get("/v1/cnpj/{cnpj}")]
        Task<ApiResponse<CnpjResponse>> ObterCnpjAsync(string cnpj);
    }
}
