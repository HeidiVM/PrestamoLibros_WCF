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
    [ServiceContract]
    public interface ILoanService
    {
        [OperationContract] bool BorrowBook(int userId, int bookId);
        [OperationContract] bool ReturnBook(int userId, int bookId);
        [OperationContract] List<Loan> GetLoansByUser(int userId);
    }
}
