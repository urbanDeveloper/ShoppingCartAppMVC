using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Entities
{
    public class ShippingDetails
    {
        //Data annotations
        [Required(ErrorMessage = "Please Enter a Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter the first line of your address")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Please Enter a City Name")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please Enter a State Name")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please Enter a Country Name")]
        public string Zip { get; set; }
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
