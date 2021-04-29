using System;
using System.ComponentModel.DataAnnotations;
namespace LibraryAPI.models
{
    public class Book
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string  Description { get; set; }
    }
}