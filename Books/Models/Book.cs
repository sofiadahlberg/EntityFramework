using System.ComponentModel.DataAnnotations;

namespace Books.Models {
    public class Book {
        //Properties
        public int Id {get; set;}
        [Display(Name = "Titel")]
         public string? Title {get; set;}
         [Display(Name = "Kategori")]
           public string? Category {get; set;}
           [Display(Name = "Beskrivning")]
            public string? Description {get; set;}
          
             public Author? Author {get; set;}
               [Display(Name = "Författare")]
            public int? AuthorId {get; set;}

    }
}