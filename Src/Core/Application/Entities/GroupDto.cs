using System.ComponentModel.DataAnnotations;

namespace SampleAspNet.Application.Entities
{
    public class GroupDto
    {
        public int GroupId { get; set; }

        [Required] [StringLength(13)] public string Name { get; set; }

        public bool IsRemoved { get; set; }
    }
}