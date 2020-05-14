﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using COVID19.Models;
using APIConsume.Models;
using Newtonsoft.Json;
using System.Net.Http;
using COVID19.Data;
using Microsoft.EntityFrameworkCore;

namespace COVID19.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly MvcMovieContext _context;
        public HomeController(MvcMovieContext  context)
        {
        
            _context = context;
        }
<<<<<<< HEAD
         
=======
>>>>>>> 7f392bf63918f2aab0df985468b29c02783ccd8b
        public async Task<IActionResult> Tracker()
        {
            List<Cases> Cases = new List<Cases>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.covid19api.com/total/country/brazil"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Cases = JsonConvert.DeserializeObject<List<Cases>>(apiResponse);
                }
            }
            return View(Cases); 
        }

        public IActionResult Index()
<<<<<<< HEAD
=======
        {
            return View();
        }

        public IActionResult Prevention()
>>>>>>> 7f392bf63918f2aab0df985468b29c02783ccd8b
        {
            return View();
        }

        public async Task<IActionResult>  Prevention()
        {
            return View(await _context.Tips.FirstOrDefaultAsync(m => m.TipsId == 1));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
