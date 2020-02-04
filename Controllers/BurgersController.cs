using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershackapi.Models;
using burgershackapi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace burgershackapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BurgersController : ControllerBase
    {

        private readonly BurgersService _bs;

        public BurgersController(BurgersService bs)
        {
            _bs = bs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Burger>> Get()
        {
            try
            {
                return Ok(_bs.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<Burger> Get(int id)
        {
            try
            {
                return Ok(_bs.GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Burger> Create([FromBody] Burger newData)
        {
            try
            {
                return Ok(_bs.Create(newData));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Burger> Edit([FromBody] Burger update, int id)
        {
            try
            {
                update.Id = id;
                return Ok(_bs.Edit(update));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<String> Delete(int id)
        {
            try
            {
                return Ok(_bs.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
