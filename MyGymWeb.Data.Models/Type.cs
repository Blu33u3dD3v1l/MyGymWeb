using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.TypeNameValidations;

namespace MyGymWeb.Data.Models
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

        public virtual IList<GroupEvents> GroupsEvents { get; set; }
    }
}
