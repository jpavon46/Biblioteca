using System.ComponentModel.DataAnnotations;
using Biblioteca.Utils;

namespace Biblioteca.Models;
public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Year { get; set; }
    public string Publisher { get; set; }
}


