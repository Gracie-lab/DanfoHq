using System.Collections.Generic;
using System.Linq;
using danfologistics.DbContexts;
using danfologistics.Models;
using Microsoft.AspNetCore.Mvc;


namespace danfo.Controllers{



    [Route("api")]
    [ApiController]
    public class BusController : ControllerBase {

        private DataContext dcontext;
        public BusController(DataContext context) {
            dcontext = context;
        }

        public void LoadDefaultBuses()
        {
            dcontext.Buses.Add(new Bus { id = 100L, name = "Toyota", color = "white" });
            dcontext.Buses.Add(new Bus { id = 200L, name = "Marcopolo", color = "Arthur" });
            dcontext.SaveChanges();

        }

        [HttpGet]
        [Route("buses")]
        public ActionResult GetBuses(){
            
            return Ok(dcontext.getBuses());
            
        }

    }
}