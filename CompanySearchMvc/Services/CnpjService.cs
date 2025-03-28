using BuscaCnpjMvc.Data;
using BuscaCnpjMvc.Models;
using BuscaCnpjMvc.Services.Apis.Refit;
using BuscaCnpjMvc.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace BuscaCnpjMvc.Services
{
    public class CnpjService : ICnpjService
    {
        private readonly ICnpjApiRefit _cnpjApiRefit;
        private readonly BuscaCnpjMvcContext _context;

        public CnpjService(ICnpjApiRefit cnpjApiRefit, BuscaCnpjMvcContext context)
        {
            _cnpjApiRefit = cnpjApiRefit;
            _context = context;
        }

        public async Task<CnpjResponse> ObterCnpjAsync(string cnpj)
        {
            var response = await _cnpjApiRefit.ObterCnpjAsync(cnpj);

            if (response != null && response.IsSuccessStatusCode)
            {
                return response.Content;
            }

            throw new Exception("CNPJ não encontrado.");
        }

        public async Task<CnpjResponse> SalvarCnpjAsync(CnpjResponse cnpjResponse)
        {
            _context.Add(cnpjResponse);
            await _context.SaveChangesAsync();
            return cnpjResponse;

        }
    }
}
