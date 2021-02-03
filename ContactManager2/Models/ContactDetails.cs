

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager2.Models
{
    public class ContactDetails
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = " nvarchar(100)")]
        public string firstname { get; set; }

        [Column(TypeName = " nvarchar(100)")]
        public string lastname { get; set; }
        
        [Column(TypeName = " nvarchar(14)")]
        public string phonenumber { get; set; }
    }
}
