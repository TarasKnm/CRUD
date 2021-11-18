using Microsoft.AspNetCore.Mvc;
using System;

namespace CRUD.Controllers
{
    public class AppointmentController : Controller
    {
        
        public IActionResult Index()
        {
           return View();
        }
        [Route("Appointment")]
        [Route("Appointment/lmaowhat")]
        [Route("Appointment/{id?}")]
        public IActionResult Details(string id)
        {
            return Ok("Your id: " + id);
            
        }
    }
}
