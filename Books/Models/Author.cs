using System.ComponentModel.DataAnnotations;
namespace Books.Models;
public class Author {
    //Properties
    public int Id {get; set;}

     [Display(Name = "Namn")]
    public string? Name {get; set;}

   public List<Book>?Books { get; set; }   
              
}