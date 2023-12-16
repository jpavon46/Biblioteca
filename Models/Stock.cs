using System.ComponentModel.DataAnnotations;
using Biblioteca.Utils;

namespace Biblioteca.Models;

public class Stock
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public int BookId { get; set; }
    public virtual Author? Author { get; set; }
    public virtual Book? Book { get; set; }
    public int Quantity { get; set; }
}