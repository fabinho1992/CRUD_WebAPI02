using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webAPI02.Infraestrutura;
using webAPI02.Infraestrutura.Dto.ProdutoDto;
using webAPI02.Models;
using webAPI02.Repository.Interfaces;

namespace webAPI02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProdutoRepository _db;
        private readonly IMapper _mapper;
        public ProductsController(IProdutoRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddProduto([FromForm]CreateProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produtos>(produtoDto);
             _db.AddProduto(produto);
            return NoContent();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var produtos =  _db.GetProdutos();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id) 
        {
             var produto = _db.GetProdutosId(id);
            if(produto == null) return NotFound();
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduto(int id,[FromForm] UpdateProdutoDto produtoDto)
        {
            _db.UpdateProdutos(id, produtoDto);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduto(int id)
        {
            _db.DeleteProdutos(id);
            return NoContent();
        }
    }
}
