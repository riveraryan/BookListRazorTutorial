using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Models
{
    public class Book
    {
        [Key] //<- ?
        public int Id { get; set; }
        [Required] //<- Cannot be null
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
