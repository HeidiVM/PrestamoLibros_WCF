using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LoanService.Models
{
    [DataContract]
    public class Loan
    {
        [DataMember] public int UserId { get; set; }
        [DataMember] public int BookId { get; set; }
        [DataMember] public string Date { get; set; }
    }
}