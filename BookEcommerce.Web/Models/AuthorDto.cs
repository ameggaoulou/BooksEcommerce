﻿namespace BookEcommerce.Web.Models
{
    public class AuthorDto
    {
        public int Id { get; set; }


        public string FullName { get; set; }
      
        public List<string> ListBookTitels { get; set; }
    }
}
