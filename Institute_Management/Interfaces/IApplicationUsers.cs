using Institute_Management.Models;

namespace Institute_Management.Interfaces
{
    public interface IApplicationUsers
    {
        public Task<IEnumerable<ApplicationUser>> GetApplicationUsers();
        public Task<ApplicationUser> GetApplicationUser(string id);
        public Task<ApplicationUser> AddApplicationUser(ApplicationUser user);
        public Task<ApplicationUser> UpdateApplicationUser(ApplicationUser user);
        public Task<ApplicationUser> DeleteApplicationUser(string id);
    }
}
