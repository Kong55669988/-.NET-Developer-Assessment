namespace Developer_Assessment.Models.Entity.Freelancers
{
    public class Freelancer : BaseEntity
    {
        public virtual string Username { get; set; }

        public virtual string Mail { get; set; }

        public virtual string PhoneNumber { get; set; } 

        public virtual string SkillSets { get; set; }

        public virtual string Hobby { get;set; }

    }
}
