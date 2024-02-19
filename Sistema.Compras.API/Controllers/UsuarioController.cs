﻿using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sistema.Compras.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return  Ok("funcionou");
            }catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}