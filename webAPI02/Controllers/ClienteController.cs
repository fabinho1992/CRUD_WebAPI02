using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using webAPI02.Infraestrutura.Dto.ClienteDto;
using webAPI02.Repository.Interfaces;

namespace webAPI02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _context;

        public ClienteController(IClienteRepository context)
        {
            _context = context;
        }

        [HttpPost("/Cadastrar")]
        public IActionResult AddCliente(CreateClienteDto clienteDto)
        {
            _context.AddCliente(clienteDto);
            return Ok();
        }

        [HttpGet("/Lista Clientes")]
        public IActionResult GetCliente()
        {
            return Ok(_context.GetCliente());
        }

        [HttpGet("/Cliente pelo {id}")]
        public IActionResult GetClienteId(int id) 
        {
            var cliente =_context.GetClienteId(id);
            return Ok(cliente);
        }

        [HttpPut("/Atualizar cadastro cliente")]
        public IActionResult UpdateCliente(int id, UpdateClienteDto clienteDto)
        {
            _context.UpdateCliente(id, clienteDto);
            return NoContent ();
        }

        [HttpPatch("/Atualizar cliente {Parcial}")]
        public IActionResult UpdatePatch(int id, JsonPatchDocument<UpdateClienteDto>  clienteDto)
        {
            _context.UpdatePath(id, clienteDto);
            return NoContent ();
        }

    }
}
