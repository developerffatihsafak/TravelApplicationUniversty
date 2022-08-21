﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class About2
    {
        [Key]
        public int About2Id { get; set; }
        public string Title { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        
        public string Image { get; set; }
    }
}
