using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using netcore_webapi.Models;
using X.PagedList;

namespace netcore_webapi.Controllers
{
    [Route("[controller]/[action]")]
    public class MobilController : ControllerBase
    {
        private int pageSize=5;
        private List<Mobil> mobils;
        public MobilController()
        {
            mobils = new List<Mobil>(){
                new Mobil("Avanza","Toyota",2001),
                new Mobil("Xenia","Daihatsu",2002),
                new Mobil("Ertiga","Suzuki",2004),
                new Mobil("Baleno","Suzuki",1996),
                new Mobil("Kijang","Toyota",1995),

                new Mobil("Jimny","Suzuki",1994),
                new Mobil("L-300","Mitsubishi",1996),
                new Mobil("Fuso","Mitsubishi",1995)
            };
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Mobil>),200)]
        [ProducesResponseType(400)]
        public IActionResult ListMobil(int pageNumber=1)
        {
            if(mobils!=null)
                return Ok(mobils.ToPagedList(pageNumber, pageSize));
            else
                return BadRequest();
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<Mobil>),200)]
        [ProducesResponseType(typeof(Mobil), 400)]
        public IActionResult AddMobil(Mobil mobil)
        {
            if (ModelState.IsValid)
            {
                mobils.Add(mobil);
                return Ok(mobils);
            }
            else
                return BadRequest(mobil);
        }


    }
}