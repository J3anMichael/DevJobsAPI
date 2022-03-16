using DevJobsAPI.Entities;

namespace DevJobsAPI.Persistencee
{
    public class DevJobsContext
    {
        public DevJobsContext()
        {
            JobVacancies = new List<JobVacancy>();
        }

        public List<JobVacancy> JobVacancies { get; set;  }
    }
}
