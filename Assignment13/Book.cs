using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    public class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return book.Title;
        }

        public static string[] GetAuthors(Book book)
        {
            return book.Authors;
        }

        public static decimal GetPrice(Book book)
        {
            return book.Price;
        }
    }
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {Authors}, PublicationDate: {PublicationDate}, Price: {Price}";
        }
    }
}
