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
            //cnpjResponse.Qsa = PreencherQsaPadrao(cnpjResponse.Qsa);
            //cnpjResponse.Simples = PreencherSimplesPadrao(cnpjResponse.Simples);
            //cnpjResponse.Simei = PreencherSimeiPadrao(cnpjResponse.Simei);
            //cnpjResponse.Billing = PreencherBillingPadrao(cnpjResponse.Billing);
            _context.Add(cnpjResponse);
            await _context.SaveChangesAsync();
            return cnpjResponse;

        }

        //private List<Qsa> PreencherQsaPadrao(List<Qsa> qsa)
        //{

        //    foreach (var item in qsa)
        //    {
        //        if (item.Nome == null)
        //        {
        //            item.Nome = "Não Informado";
        //        }

        //        if (item.Qual == null)
        //        {
        //            item.Qual = "Não Informado";
        //        }

        //        if (item.PaisOrigem == null)
        //        {
        //            item.PaisOrigem = "Não Informado";
        //        }
        //        if(item.NomeRepLegal == null)
        //        {
        //            item.NomeRepLegal = "Não Informado";
        //        }
        //        if(item.QualRepLegal == null)
        //        {
        //            item.QualRepLegal = "Não Informado";
        //        }
        //    }
        //    return qsa;
        //}

        //private Simples PreencherSimplesPadrao(Simples simples)
        //{
        //    if (simples.Optante == null)
        //    {
        //        simples.Optante = false;
        //    }

        //    if (simples.DataOpcao == null)
        //    {
        //        simples.DataOpcao = DateTime.MinValue;
        //    }
        //    return simples;
        //}

        //private Simei PreencherSimeiPadrao(Simei simei)
        //{
        //    if (simei.Optante == null)
        //    {
        //        simei.Optante = false;
        //    }

        //    if (simei.DataOpcao == null)
        //    {
        //        simei.DataOpcao = DateTime.MinValue;
        //    }
        //    return simei;
        //}

        //private Billing PreencherBillingPadrao(Billing billing)
        //{

        //    if (billing.Optante == null)
        //    {
        //        billing.Optante = false;
        //    }

        //    if (billing.Database == null)
        //    {
        //        billing.Database = false;
        //    }
        //    return billing;
        //}
    }
}
