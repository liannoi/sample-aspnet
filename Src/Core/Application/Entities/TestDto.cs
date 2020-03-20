using System.ComponentModel.DataAnnotations;

namespace SampleAspNet.Application.Entities
{
    public class TestDto
    {
        public int TestId { get; set; }

        [Required] [StringLength(256)] public string Title { get; set; }

        [StringLength(4000)] public string Description { get; set; }

        public bool IsRemoved { get; set; }
    }
}