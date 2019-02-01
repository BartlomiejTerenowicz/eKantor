using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eKantor.Models
{
    public class Person
    {
        [Key]
        public string UserId { get; set; }

        public string UserName { get; set; }
    }
}
