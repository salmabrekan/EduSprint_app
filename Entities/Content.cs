﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace EduSprint.Entities
{
    public class Content
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }

        public string HTMLContent { get; set; }

        public string VideoLink { get; set; }
         
        public CategoryItem CategoryItem { get; set; }
        
        [NotMapped]
       
        public int CatItemId { get; set; }
        //Note: This property cannot be 
        //named CategoryItemId because this would
        //interfere with future migrations
        //It has been named like this
        //so as not to conflict with EF Core naming conventions

        [NotMapped]
        public int CategoryId { get; set; }

       
    }
}
