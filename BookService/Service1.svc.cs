using BookService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BookService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class BookService : IBookService
    {
        private static List<Book> books = new List<Book>()
    {
        new Book { Id = 1, Title = "Cien Años de Soledad", Author = "García Márquez", Year = 1967 },
        new Book { Id = 2, Title = "1984", Author = "George Orwell", Year = 1949 }
    };

        public List<Book> GetAllBooks() => books;

        public Book GetBookById(int id) =>
            books.FirstOrDefault(b => b.Id == id);

        public bool AddBook(Book book)
        {
            books.Add(book);
            return true;
        }

        public bool UpdateBook(Book book)
        {
            var b = books.FirstOrDefault(x => x.Id == book.Id);
            if (b == null) return false;

            b.Title = book.Title;
            b.Author = book.Author;
            b.Year = book.Year;
            return true;
        }

        public bool DeleteBook(int id)
        {
            var b = books.FirstOrDefault(x => x.Id == id);
            return books.Remove(b);
        }
    }
}
