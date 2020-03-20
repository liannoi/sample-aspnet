﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SampleAspNet.Application.Entities
{
    public class GroupTestDto
    {
        [Key] public int RecordId { get; set; }

        public int GroupId { get; set; }

        public int TestId { get; set; }

        public bool IsPassed { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }

        public bool IsRemoved { get; set; }
    }
}