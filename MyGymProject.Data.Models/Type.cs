using System.ComponentModel.DataAnnotations;
using static MyGymProject.Common.Constants.ValidationConstants.TypeNameValidations;

namespace MyGymProject.Data.Models
{
    public class Type
    {

        public Type()
        {
            this.GroupsEvents = new List<GroupEvents>();
        }

        [Key]
        public int Id { get; set; }

       
        [MaxLength(NameMaxValidation)]
        [Required]
        public string Name { get; set; } = null!;

        public IList<GroupEvents> GroupsEvents { get; set; }
    }
}
