using LoanService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LoanService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class LoanService : ILoanService
    {
        private static List<Loan> loans = new List<Loan>();

        public bool BorrowBook(int userId, int bookId)
        {
            loans.Add(new Loan
            {
                UserId = userId,
                BookId = bookId,
                Date = DateTime.Now.ToShortDateString()
            });
            return true;
        }

        public bool ReturnBook(int userId, int bookId)
        {
            var loan = loans.FirstOrDefault(l => l.UserId == userId && l.BookId == bookId);
            if (loan == null) return false;

            loans.Remove(loan);
            return true;
        }

        public List<Loan> GetLoansByUser(int userId) =>
            loans.Where(l => l.UserId == userId).ToList();
    }
}
