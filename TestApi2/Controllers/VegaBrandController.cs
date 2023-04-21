using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApi2.Models;

namespace TestApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VegaBrandController : ControllerBase
    {
        [HttpPost("GetAllData")]
        public List<VegaBrand> GetAll(VegaBrand vegaBrend)
        {
            //VegaBrand responseModel = VegaVestaNewContext.VegaBrands.Where(a => a.email == "" && a.password == "").ToList();
            var vegaVestaNewContext = new VegaVestaNewContext();
            List<VegaBrand> responseModel = vegaVestaNewContext.VegaBrands.Where(x => x.Id >= 1).ToList();
            return responseModel;
        }
    }
}
