using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data
{
    public partial class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public int? Year { get; set; }
        public string Isbn { get; set; } = null!;
        public string? Summary { get; set; }
        public decimal? Price { get; set; }
        public Guid? AuthorId { get; set; }

        public virtual Author? Author { get; set; }
    }
}
