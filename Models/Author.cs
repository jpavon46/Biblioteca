using System.ComponentModel.DataAnnotations;
using Biblioteca.Utils;

namespace Biblioteca.Models; 

public class Author
{
    public int Id {get; set;}
    public string? Name { get; set; }
    public int Birth { get; set; }
    public string? Nationality { get; set; }
    public virtual List<Book>? Books { get; set; }
    public virtual List<Stock>? Stocks { get; set; }
}