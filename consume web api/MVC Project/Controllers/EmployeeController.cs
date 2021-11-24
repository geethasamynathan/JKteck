using ConsumewebApiinMvcdemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsumewebApiinMvcdemo.Controllers
{
    public class EmployeeController : Controller
    {
        IEnumerable<Employee> Employees = null;
        // GET: Employee
        public async Task<ActionResult> Index()
        {
            Employees = new List<Employee>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44311");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("/api/Employees/GetEmployees");
           
               
                if (response.IsSuccessStatusCode)
                {
                    var resultResponse = response.Content.ReadAsStringAsync().Result;
                    Employees = JsonConvert.DeserializeObject<List<Employee>>(resultResponse);
                }
                else
                {
                    Employees = Enumerable.Empty<Employee>();
                    ModelState.AddModelError(string.Empty, "Server Error try afer come time");
                }
            }
            return View(Employees);
        }
    }
}