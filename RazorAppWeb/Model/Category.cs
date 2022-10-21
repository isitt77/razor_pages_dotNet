﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorAppWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        [DisplayName("Display Order")]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
    }
}
