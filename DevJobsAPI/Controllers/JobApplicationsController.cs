namespace DevJobsAPI.Controllers
{
    using DevJobsAPI.Entities;
    using DevJobsAPI.Models;
    using DevJobsAPI.Persistencee;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/job-vacancies/{id}/applications")]
    [ApiController]
    public class JobApplicationsController : ControllerBase
    {
        private readonly DevJobsContext _context;
        public JobApplicationsController(DevJobsContext context)
        {
            _context = context;
        }

        // GET api/job-vacancies/4
        [HttpPost]
        public IActionResult Post(int id, AddJobApplicationInputModel model)
        {
            var jobVacancy = _context.JobVacancies.SingleOrDefault(jv => jv.Id == id);

            if (jobVacancy == null)
                return NotFound();

            var application = new JobApplication(
                model.ApplicantName,
                model.ApplicantEmail,
                id
                );

            jobVacancy.Applications.Add(application);
            return NoContent();
        }

        
    }
}
