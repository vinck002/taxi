using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace taxi.web.Data.Entities
{
    public class TaxiEntity
    {

       
       public int Id { get; set; }
        [StringLength(6, MinimumLength =6,ErrorMessage =" The {0} field must have {1} characters.")]
        [Required(ErrorMessage ="the field {0} is mandatory.")]
        [RegularExpression(@"^([A-Za-z]{3}\d{3})$", ErrorMessage =" the field {0} must START WITH three  characters and ends with number")]
        public string Plaque { get; set; }
        public ICollection<TripEntity> Trips { get; set; }

        

    }
}
