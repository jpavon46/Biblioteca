using System.ComponentModel.DataAnnotations;
using Biblioteca.Utils;

namespace Biblioteca.Models;
public class Book
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Year { get; set; }
    public string? Publisher { get; set; }
    public Genre Genre { get; set; }
    public virtual List<Author>? Authors { get; set; }
    public int? StateId { get; set; }
    public virtual State? State { get; set; }
    public virtual List<Stock>? Stocks { get; set; }
}


