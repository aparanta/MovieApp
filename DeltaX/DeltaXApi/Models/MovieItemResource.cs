using System;
using System.Collections.Generic;

namespace DeltaXApi.Models
{
    public class MovieItemResource
    {
        public int Id { get; set; }
        public string Name { get; set; }     
        public DateTime ReleaseYear{ get; set; }
        public string Plot { get; set; }
        public string PosterPath { get; set; }         
        public Producer Producer { get; set; }
        public   List<Actor> MovieActor { get; set; }
    }
}