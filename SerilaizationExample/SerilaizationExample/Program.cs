using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace SerilaizationExample
{
    public class Book
    {
        public Author Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author
            {
                Name = "Author Name",
                Age = 35
            };

            List<Book> books = new List<Book>
            {
                new Book
                {
                    Title = "Title 1",
                    Genre = "Genre 1",
                    Author = author
                },

                new Book
                {
                    Title = "Title 2",
                    Genre = "Genre 2",
                    Author = author
                }
            };

            // XML serialisation

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));

            TextWriter writer = new StreamWriter("test.xml");

            xmlSerializer.Serialize(writer, books);

            writer.Close();

            // XML deserialisation

            FileStream fileStream = new FileStream("test.xml", FileMode.Open, FileAccess.Read);

            var obj = (List<Book>)xmlSerializer.Deserialize(fileStream);

            fileStream.Close();

            // JSON serialisation

            var serializedJson = JsonSerializer.Serialize(books);

            // JSON deserialisation

            var deserializedBooks = JsonSerializer.Deserialize<List<Book>>(serializedJson);
        }
    }
}
