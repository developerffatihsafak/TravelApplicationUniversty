using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class TestiMonial
    {
        [Key]
        public int TestiMonialId { get; set; }
        public string Client { get; set; }
        public string Commend { get; set; }
        public string ClientImage { get; set; }
        public bool Status { get; set; }
    }
}
