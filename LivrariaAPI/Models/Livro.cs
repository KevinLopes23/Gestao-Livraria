namespace LivrariaAPI.Models;

public class Livro
{
    public int Id { get; set; }
    public String Titulo { get; set; }
    public string Autor {  get; set; }
    public string Genero { get; set; }
    public decimal Preco { get; set; }
    public int QntEmEstoque { get; set; }
}
