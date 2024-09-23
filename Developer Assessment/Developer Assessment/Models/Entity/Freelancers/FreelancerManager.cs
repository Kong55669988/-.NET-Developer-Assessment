using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Developer_Assessment.Models.Entity.Freelancers
{
    public class FreelancerManager
    {
        private readonly IRepository<Freelancer, long> _freelanceRepository;

        public FreelancerManager(IRepository<Freelancer, long> freelanceRepository)
        {
            _freelanceRepository = freelanceRepository ?? throw new ArgumentNullException(nameof(freelanceRepository));
        }
         
        public IQueryable<Freelancer> Freelancers {
            get { 
                return _freelanceRepository.GetAll().Where(s => s.isActive == true);
            } }
        public Task<Freelancer> GetAsync(long id) => _freelanceRepository.FirstOrDefaultAsync(f => f.Id == id);

        public async Task CreateOrUpdateAsync(Freelancer freelancer)
        {
            if (freelancer.Id == 0)
            {
                freelancer.isActive = true;
                freelancer.CreatedTime= DateTime.UtcNow;
                freelancer.ModifiedTime=  DateTime.UtcNow;
                await _freelanceRepository.InsertAsync(freelancer);
            }
            else
            {
                freelancer.ModifiedTime = DateTime.UtcNow;
                await _freelanceRepository.UpdateAsync(freelancer);
            }
        }


        public async Task DeleteAsync(Freelancer freelancer)
        {
            if (freelancer.Id != 0)
            {
               var deletingData = await _freelanceRepository.FirstOrDefaultAsync(m => m.Id == freelancer.Id);
                deletingData.isActive = false;
                await _freelanceRepository.UpdateAsync(deletingData);
                
            }
        }
    }

}
