using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BookService.Models
{
    [DataContract]

    public class Book
    {
        [DataMember] public int Id { get; set; }
        [DataMember] public string Title { get; set; }
        [DataMember] public string Author { get; set; }
        [DataMember] public int Year { get; set; }
    }
}