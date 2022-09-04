using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNet6Test.Models
{
    public class Books
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]  //alias name saka
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100 only!!")]
        public int DisplayOrder { get; set; }

        //public DateTime CreatedOn { get; set; } = DateTime.Now;


    }
}
//refer data annotation in official docs