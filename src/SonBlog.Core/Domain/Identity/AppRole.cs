using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SonBlog.Core.Domain.Identity
{
    [Table("AppRoles")]
    public class AppRole : IdentityRole<Guid>
    {
        [Required]
        [MaxLength(200)]
        public required string DisplayName { get; set; }
    }
}
