using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuscaCnpjMvc.Data;
using BuscaCnpjMvc.Models;
using Refit;
using BuscaCnpjMvc.Services.Interfaces;

namespace BuscaCnpjMvc.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CnpjResponsesController : Controller
    {
        private readonly BuscaCnpjMvcContext _context;
        private readonly ICnpjService _cnpjService;

        public CnpjResponsesController(BuscaCnpjMvcContext context, ICnpjService cnpjService)
        {
            _context = context;
            _cnpjService = cnpjService;
        }

        public async Task<IActionResult> Index()
        {
            var cnpjsCadastrados = await _context.CnpjResponse.ToListAsync();
            return View(cnpjsCadastrados);
        }

        [HttpGet("ObterCnpj")]
        public async Task<IActionResult> ObterCnpj(string? cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj))
            {
                return View();
            }

            var response = await _cnpjService.ObterCnpjAsync(cnpj);

            if (response == null)
            {
                ModelState.AddModelError("Cnpj", "CNPJ não encontrado.");
                return View();
            }

            return View(response);
        }

        [HttpPost("SalvarCnpj")]
        public async Task<IActionResult> SalvarCnpj([FromBody] CnpjResponse cnpjResponse)
        {
            if (cnpjResponse == null)
            {
                return BadRequest("CNPJ não pode ser nulo.");
            }

            if (ModelState.IsValid)
            {
                await _cnpjService.SalvarCnpjAsync(cnpjResponse);
                return RedirectToAction(nameof(Index));
            }
            return BadRequest(ModelState);
        }

    }
}
