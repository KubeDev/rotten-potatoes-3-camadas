using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Rotten_Potatoes.Api.Entity;
using Rotten_Potatoes.Domain;
using Rotten_Potatoes.Domain.Models;

namespace Rotten_Potatoes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private readonly ILogger<FilmeController> _logger;
        private readonly AppDbContext _context;

        public FilmeController(ILogger<FilmeController> logger, AppDbContext context)
        {
            _logger = logger;
            this._context = context;
        }

        [HttpGet]

        public IEnumerable<Filme> Get()
        {
            var resultado = this._context.Filmes.ToList();
            return resultado;
        }

        [HttpGet("{id}", Name = "GetFilme")]
        public Filme Get(int id)
        {
            var filme = this._context.Filmes.Where(i => i.FilmeId == id).SingleOrDefault();

            if (filme != null)
            {
                filme.Reviews = this._context.Reviews.Where(i => i.FilmeId == id).ToList();
            }

            return filme;
        }

        // [HttpPost]
        // public IActionResult Post([FromBody] Filme filme)
        // {
        //     this._context.Filmes.Add(filme);
        //     this._context.SaveChanges();
        //     return Ok();
        // }

        [HttpPost("{id}/review", Name = "AddReview")]
        public IActionResult AddReview([FromRoute] int id, [FromBody] Review review)
        {
            Filme filme = this._context.Filmes.Where(i => i.FilmeId == id).SingleOrDefault();

            if (filme != null)
            {
                filme.AddReview(review);
                this._context.SaveChanges();
            }

            return Ok();
        }
    }

}
