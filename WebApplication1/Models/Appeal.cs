using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models {
    public interface IAppeal {

        int id { get; set; }

        [StringLength(40, MinimumLength = 10)]
        [Required]
        [Display(Name = "Kirjeldus")]
        String kirjeldus { get; set; }


        [Display(Name = "Lahendamise tähtaeg")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        DateTime lahendamiseT2htAeg { get; set; }

        [Display(Name = "Sisestamims aeg")]
        DateTime sisestamisAeg { get; set; }

        Boolean onLahendatud { get; set; }
    }
    public class Appeal : IAppeal {
        public int id { get; set; }

        public string kirjeldus{get ;set;}

        public DateTime lahendamiseT2htAeg { get; set; }

        public DateTime sisestamisAeg {get;set;} = DateTime.Now;
        public bool onLahendatud { get; set; } = false;
        
    }
}