using Institute_Management.Data;
using Institute_Management.Interfaces;
using Institute_Management.Models;
using Microsoft.EntityFrameworkCore;


namespace Institute_Management.Repository
{
    public class ApplicationUserRepo : IApplicationUsers
    {
        private readonly AppDbContext dbContext;

        public ApplicationUserRepo(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<ApplicationUser> AddApplicationUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<ApplicationUser> DeleteApplicationUser(string id)
        {
            ApplicationUser user = await dbContext.ApplicationUsers.FindAsync(id);
            if(user!=null)
            {
                dbContext.ApplicationUsers.Remove(user);
                dbContext.SaveChanges();
            }
            return user;
        }

        public async Task<ApplicationUser> GetApplicationUser(string id)
        {
            return await dbContext.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<ApplicationUser>> GetApplicationUsers()
        {
            return await dbContext.ApplicationUsers.ToListAsync();
        }

        public async Task<ApplicationUser> UpdateApplicationUser(ApplicationUser user)
        {
            ApplicationUser applicationUser = await dbContext.ApplicationUsers.FindAsync(user.Id);
            if(applicationUser!=null)
            {
                applicationUser.Name = user.Name;
                applicationUser.Email = user.Email;
                applicationUser.UserName=user.UserName;
                applicationUser.PhoneNumber = user.PhoneNumber;
                applicationUser.InstituteName = user.InstituteName;
                
            }
           await dbContext.SaveChangesAsync();
            return user;
        }
    }
}
