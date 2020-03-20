﻿using System.ComponentModel.DataAnnotations;

namespace SampleAspNet.Application.Entities
{
    public class AnswerDto
    {
        public int AnswerId { get; set; }

        public int QuestionId { get; set; }

        [Required] [StringLength(256)] public string Text { get; set; }

        public bool IsSuitable { get; set; }

        public bool IsRemoved { get; set; }
    }
}