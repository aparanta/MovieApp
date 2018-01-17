using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaXApi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseYear{ get; set; }
        public string Plot { get; set; }
        public string PosterPath { get; set; }
        
        [ForeignKey("Producer")]
        public int ProducerID {get; set;}
        public Producer Producer { get; set; }
        public   ICollection<MovieActor> MovieActor { get; set; }
    }
}