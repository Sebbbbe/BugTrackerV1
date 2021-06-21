using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models

{
    public class Project
    {
        //relation med issue / med user också?

        // ett projekt har flera issues medan en issue har bara en projekt
        // issue är dependent entity
        [Key]
        public Guid Project_id { get; set; }

        public string Project_Name { get; set; }

        // skapar relationen där project kan ha flera Issues
        public List<Issue> Issues { get; set; }


    }
}
