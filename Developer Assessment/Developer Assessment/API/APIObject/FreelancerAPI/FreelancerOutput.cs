using Developer_Assessment.Models.Entity.Freelancers;

namespace Developer_Assessment.API.APIObject.FreelancerAPI
{
    public class FreelancerOutput
    {
        public List<Freelancer> FreelancerList { get; set; }

        public string ErrMsg { get; set; }
    }
}
