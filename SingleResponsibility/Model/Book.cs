using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Model
{
    public class Book
    {
        public Book(int id, string? title, decimal price, string? description, DateTime publishedTime)
        {
            Id = id;
            Title = title;
            Price = price;
            Description = description;
            PublishedTime = publishedTime;
        }

        public int Id { get; private set; }
        public string? Title { get; private set; }
        public decimal Price { get; private set; }
        public string? Description { get;  private set; }
        public DateTime PublishedTime { get; private set; }
        public override string ToString()
        {
            return $"BookId -> {Id}\nTitle -> {Title}\nPrice -> {Price:C}\nDescription -> {Description}\nPublishedDate -> {PublishedTime:dddd, MMMM dd, yyyy}";
        }
    }
}
