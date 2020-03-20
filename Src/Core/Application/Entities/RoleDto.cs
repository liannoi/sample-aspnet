using System.ComponentModel.DataAnnotations;

namespace SampleAspNet.Application.Entities
{
    public class RoleDto
    {
        public int RoleId { get; set; }

        [Required] [StringLength(128)] public string Name { get; set; }

        public bool IsRemoved { get; set; }
    }
}