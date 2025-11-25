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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract] List<Book> GetAllBooks();
        [OperationContract] Book GetBookById(int id);
        [OperationContract] bool AddBook(Book book);
        [OperationContract] bool UpdateBook(Book book);
        [OperationContract] bool DeleteBook(int id);
    }
}
