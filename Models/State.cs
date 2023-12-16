using System.ComponentModel.DataAnnotations;
using Biblioteca.Models;
public class State
{
    public int Id { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime ReturnData { get; set; }
}