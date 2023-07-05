
using Microsoft.AspNetCore.Identity;

namespace Institute_Management.Interfaces
{
    public interface IRoles
    {
        
        public IEnumerable<IdentityRole> GetRoles();
        public IdentityRole AddRole(IdentityRole role);
        public IdentityRole UpdateRole(IdentityRole role);
        public IdentityRole DeleteRole(int id);
    }
}
