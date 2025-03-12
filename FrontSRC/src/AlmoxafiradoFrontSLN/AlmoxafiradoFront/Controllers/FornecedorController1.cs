using AlmoxafiradoFront.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;

namespace AlmoxafiradoFront.Controllers
{
    public class FornecedorController : Controller
    {
        public IActionResult Index()
        {
            var url = "https://localhost:44366/lista";
            List<FornecedorDTO> fornecedors = new List<FornecedorDTO>();
            using HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                string json = response.Content.ReadAsStringAsync().Result;
                fornecedors = JsonSerializer.Deserialize<List<FornecedorDTO>>(json);
                ViewBag.Fornecedor = fornecedors;


            }
            catch (Exception)
            {
                return View();

            }

            return View();
        }
    }
}
namespace AlmoxafiradoFront
{
    class FornecedorDTO
    {
    }
}