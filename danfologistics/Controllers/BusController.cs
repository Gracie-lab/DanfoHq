using System.Collections.Generic;
using System.Linq;
using danfologistics.DbContexts;
using Microsoft.AspNetCore.Mvc;


namespace danfo.Controllers{



    [Route("api")]
    [ApiController]
    public class BusController : ControllerBase {

        private DataContext dcontext;
        public BusController(DataContext context) {
            dcontext = context;
        }

        [HttpGet]
        [Route("buses")]
        public ActionResult GetBuses(){
            return Ok(dcontext.getBuses());
        }
    }
}