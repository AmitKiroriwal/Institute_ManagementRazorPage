

using Microsoft.AspNetCore.Identity;

namespace Institute_Management.Interfaces
{
    public interface IUserRoles
    {
        
        public IEnumerable<IdentityRole> GetUserRoles();
        public IdentityRole GetUserByRole(string role );
        public IdentityRole AddUserRole(IdentityRole role);
        public IdentityRole UpdateUserRole(IdentityRole role);
        public IdentityRole DeleteUserRole(int id);
    }
}
