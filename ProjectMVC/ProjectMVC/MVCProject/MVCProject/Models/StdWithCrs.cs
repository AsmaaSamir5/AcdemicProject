﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class StdWithCrs
    {
        public int Id { get; set; }

        public int Degree { get; set; }

        [ForeignKey("Course")]
        public int CrsId { get; set; }
        [ForeignKey("Student")]

        public int StId { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }


    }
}
