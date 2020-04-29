using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using TahaBloggerProject.Entities.Dtos;
using TahaBloggerProject.Entities.DTOS;
using TahaBloggerProject.Entities.Models;
using TahaBloggerProject.UI.Models;

namespace TahaBloggerProject.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient client = new HttpClient();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



     

        public async Task<ActionResult> Index()
        {
            List<Category> model = null;
            
            var task = await client.GetAsync("https://localhost:44307/ListOfCategory");
            var jsonString = await task.Content.ReadAsStringAsync();
            model = JsonConvert.DeserializeObject<List<Category>>(jsonString); 
          
            return View(model);


            //PartialViewleri Yap. Ajax işlemlerine bak ve adm abinin whatsappda ddiklerine
        }

         

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterDto user)
        {
            var data = JsonConvert.SerializeObject(user); // NEwtonSoft ile  Jsona cevirdim.
            var json = new StringContent(data, Encoding.UTF8, "application/json"); //Datamızın tipini gösterdim.
            var response = client.PostAsync("https://localhost:44307/AddNewUser", json); //buraya jsonu ver.
            var result = response.Result.Content.ReadAsStringAsync().Result; //Dönen datayı string olarak çektim.
            var deserializeData = JsonConvert.DeserializeObject(result); //Deserialize ettik.

            return RedirectToAction("RegisterOK");

            //return View(deserializeData);
        }
        public IActionResult RegisterOK()
        {
          
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginDto loginDto)
        {
            var data = JsonConvert.SerializeObject(loginDto);
            var json = new StringContent(data, Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:44307/LoginWithUser", json);
            var result = response.Result.IsSuccessStatusCode.ToString();
            var IsSuccess = Convert.ToBoolean(result);
            if (IsSuccess == false)
            {
                return RedirectToAction("Login");

            }
            else
            {
                return View("Index", null);
            }
       
          
        }
    }
}
