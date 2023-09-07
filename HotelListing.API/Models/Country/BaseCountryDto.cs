using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country
{
    //abstract class means you can't initialize or instantiate them as stand alone objects. They are usually used for inheritance purposes.
    public abstract class BaseCountryDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
