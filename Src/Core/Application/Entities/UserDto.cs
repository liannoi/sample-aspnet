using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleAspNet.Application.Entities
{
    public class UserDto
    {
        public int UserId { get; set; }

        public int? GroupId { get; set; }

        [Required] [StringLength(64)] public string FirstName { get; set; }

        [Required] [StringLength(64)] public string LastName { get; set; }

        [Required] [StringLength(64)] public string MiddleName { get; set; }

        [Column(TypeName = "date")] public DateTime Birthday { get; set; }

        [Required] [StringLength(128)] public string Email { get; set; }

        public bool IsEmailVerified { get; set; }

        [StringLength(17)] public string PhoneNumber { get; set; }

        public bool IsPhoneVerified { get; set; }

        [Required] [StringLength(128)] public string Login { get; set; }

        [Required] [StringLength(128)] public string Password { get; set; }

        public bool IsRemoved { get; set; }
    }
}