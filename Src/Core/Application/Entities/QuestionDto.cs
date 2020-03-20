using System.ComponentModel.DataAnnotations;

namespace SampleAspNet.Application.Entities
{
    public class QuestionDto
    {
        public int QuestionId { get; set; }

        [Required] [StringLength(256)] public string Text { get; set; }

        public int TestId { get; set; }

        public bool IsRemoved { get; set; }
    }
}