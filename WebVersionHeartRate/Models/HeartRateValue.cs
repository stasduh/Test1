using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVersionHeartRate.Models
{
    public class HeartRateValue
    {
        [Key]
        public Guid guid { get; set; }
        
        [Display(Name = "Спортсмен")]
        public Sportsman sportsman { get; set; }
       
        [Display(Name = "ЧСС")]
        public int heartRate { get; set; }
       
        [Display(Name = "Дата и время показания")]
        public DateTime dateTime { get; set; }
    }
}