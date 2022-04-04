using System.Collections.Generic;
using System.Threading.Tasks;
using TUTAPI.Models;

namespace TUTAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
