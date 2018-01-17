using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeltaXApi.Models
{   public enum Sex {Male, Female, Other}; 
    public class Producer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth{ get; set; }
        
        public  Sex  sex { get; set; }
        public string Bio {get;set;}
        
        
    }
}