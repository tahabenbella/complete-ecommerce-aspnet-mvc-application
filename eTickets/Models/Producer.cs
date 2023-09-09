using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer : IEntityBase
	{

        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
		[Required(ErrorMessage = "Profile Picture is required")]
		public string ProfilePictureURL { get; set; }
		[Display(Name = "Name")]
		[Required(ErrorMessage = "Full Name is required")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be 3 and 50 chars")]
		public string FullName { get; set; }
		[Display(Name = "Biography")]
		[Required(ErrorMessage = "Biography is required")]
		public string Bio { get; set; }

        //Relationchips
        public List<Movie>? Movies { get; set; }

    }
}
