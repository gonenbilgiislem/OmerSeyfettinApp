namespace OmerSeyfettinApp.Models
{
    using System.Data.Entity;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    // ApplicationUser sınıfınıza daha fazla özellik ekleyerek kullanıcıya profil verileri ekleyebilirsiniz. Daha fazla bilgi için lütfen https://go.microsoft.com/fwlink/?LinkID=317594 adresini ziyaret edin.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // authenticationType özelliğinin CookieAuthenticationOptions.AuthenticationType içinde tanımlanmış olanla eşleşmesi gerektiğini unutmayın
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Özel kullanıcı taleplerini buraya ekle
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("OmerSeyfettinAppDb", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}