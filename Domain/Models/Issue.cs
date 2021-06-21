using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Issue
    {
        // relation med comment / user / project
        
        [Key]
        public Guid Issue_id { get; set; }

        public string Summary { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }




        public Guid? User_id { get; set; }
        // en issue har med all information som finns i user

        public User User { get; set; }

        // skapar en dependent entity genom project_id

        public Guid? Project_id { get; set; }

        //Allt i project behövs i issue för att veta i vilket
        //projekt "folder" den ska vara i
        public Project Project { get; set; }


        // varje issue har comments som man kan se
        public List<Comment> Comments { get; set; }
    }
}
