using System.ComponentModel.DataAnnotations;

namespace Developer_Assessment.Models.Entity
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        //For Soft delete
        public Boolean isActive { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime ModifiedTime { get; set; }  

    }
}
