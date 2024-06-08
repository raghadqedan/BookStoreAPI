﻿namespace BookStore.Models
{
    public class BookCategory
    {
        private Category category;

        public int BookId { get; set; }
        public Book Book { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    } 
}
