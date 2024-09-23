using Developer_Assessment.API.APIObject.FreelancerAPI;
using Developer_Assessment.Controllers.Dto;
using Developer_Assessment.Models;
using Developer_Assessment.Models.Entity.Freelancers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Developer_Assessment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FreelancerManager _freelancerManager; 
        public HomeController(ILogger<HomeController> logger, FreelancerManager freelancerManager)
        {
            _logger = logger;
            _freelancerManager = freelancerManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region API 
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetFreelancer([FromQuery] FreelancerAPIparam param)
        {
            // If param.Id is null, default to 0 to get all freelancers
            if (param.Id == null)
            {
                param.Id = 0;
            }

            var output = await RetrieveFreelancers(param.Id);
            return Ok(output);
        }

        public async Task<FreelancerOutput> RetrieveFreelancers(int? id)
        {
            var output = new FreelancerOutput();
            try
            {
                if (id == 0)
                {
                    // Retrieve all freelancers
                    output.FreelancerList = await _freelancerManager.Freelancers.ToListAsync();
                }
                else
                {
                    // Retrieve a specific freelancer by Id
                    var freelancer = await _freelancerManager.Freelancers
                        .Where(m => m.Id == id)
                        .FirstOrDefaultAsync();

                    // Add the freelancer to the list if found
                    if (freelancer != null)
                    {
                        output.FreelancerList = new List<Freelancer> { freelancer };
                    }
                    else
                    {
                        output.FreelancerList = new List<Freelancer>();
                        output.ErrMsg = "Freelancer not found.";
                    }
                }
            }
            catch (Exception ex)
            {
                output.FreelancerList = new List<Freelancer>();
                output.ErrMsg = ex.Message; // Optionally, consider logging the exception
            }

            return output;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> RegisterFreelancer([FromBody] FreelancerInput input)
        { 
            if (input == null)
            {
                return BadRequest("input cannot be null.");
            }

            // Assuming there's a method to register the user
            var result = await InsertOrUpdateFreelancer(input);

            if (result==true)
            {
                return Ok("User registered successfully.");
            }
            else
            {
                return Ok("Registered Failed");
            }
        }

        public async Task<Boolean> InsertOrUpdateFreelancer([FromBody] FreelancerInput input)
        {
            var status = false;
            try
            {
                if (input.Freelancer.Id != 0)
                {
                    var temp = await _freelancerManager.Freelancers.Where(m => m.Id == input.Freelancer.Id).FirstOrDefaultAsync();
                    temp.PhoneNumber = input.Freelancer.PhoneNumber;
                    temp.Username = input.Freelancer.Username;
                    temp.Mail = input.Freelancer.Mail;
                    temp.SkillSets = input.Freelancer.SkillSets;
                    temp.Hobby = input.Freelancer.Hobby;

                    await _freelancerManager.CreateOrUpdateAsync(temp);
                }
                else
                {
                    await _freelancerManager.CreateOrUpdateAsync(input.Freelancer);
                }
                status = true;
            }
            catch (Exception ex) { 
            
            }

            return status;
        }

        [AllowAnonymous]
        [HttpPut]
        public async Task<IActionResult> UpdateFreelancer([FromBody] FreelancerInput input)
        {
            if (input == null)
            {
                return BadRequest("input cannot be null.");
            }

            // Assuming there's a method to register the user
            var result = await InsertOrUpdateFreelancer(input);

            if (result == true)
            {
                return Ok("User update successfully.");
            }
            else
            {
                return Ok("Update Failed");
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public async Task<IActionResult> DeleteFreelancer([FromBody] FreelancerInput input)
        {
            if (input == null)
            {
                return BadRequest("input cannot be null.");
            }
    
            // Assuming there's a method to register the user
            var result = await RemoveFreelancer(input);

            if (result == true)
            {
                return Ok("User update successfully.");
            }
            else
            {
                return Ok("Update Failed");
            }
        }

        public async Task<Boolean> RemoveFreelancer([FromBody] FreelancerInput input)
        {
            var status = false;
            try {
                if (input.Freelancer.Id != 0)
                {

                    await _freelancerManager.DeleteAsync(input.Freelancer);
                    status = true;
                }
            }
            catch(Exception ex) { 
            
            
            } 

            return status;
        }

        #endregion
    }
}
