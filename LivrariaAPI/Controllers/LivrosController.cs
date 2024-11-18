using LivrariaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivrariaAPI.Controllers;
[Route("api/[controller]")]
[ApiController]

public class LivrosController : ControllerBase
{
    private readonly LivroContext _context;

    public LivrosController(LivroContext context)
    {
        _context = context;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Livro>> GetLivro(int id)
    {
        var livro = await _context.Livros.FindAsync(id);

        if (livro == null)
        {
            return NotFound();
        }
        return livro;
    }


    [HttpPost]
    public async Task<ActionResult<Livro>> PostLivro(Livro livro)
    {
        _context.Livros.Add(livro);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetLivro), new { id = livro.Id }, livro);
    }

    [HttpPut("{id}")]

    public async Task<ActionResult> PutLivro(int id, Livro livro)
    {
        if (id != livro.Id)
        {
            return BadRequest();
        }

        _context.Entry(livro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!LivroExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();

    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteLivro(int id)
    {
        var livro = await _context.Livros.FindAsync(id);
        if (livro == null)
        {
            return NotFound();
        }

        _context.Livros.Remove(livro);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool LivroExists(int id)
    {
        return _context.Livros.Any(l => l.Id == id);
    }

}
