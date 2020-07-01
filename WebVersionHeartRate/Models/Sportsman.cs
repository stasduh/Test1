using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVersionHeartRate.Models
{
    public class Sportsman
    {
        [Key]
        public Guid guid { get; set; }

        [Display(Name = "Номер")]
        public int formNumber { get; set; }

        [Display(Name = "Имя")]
        public string firstName { get; set; }

        [Display(Name = "Фамилия")]
        public string lastName { get; set; }
    }
}