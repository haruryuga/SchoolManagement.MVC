﻿using System;
using System.Collections.Generic;

namespace SchoolManagement.MVC.Data;

public partial class Class
{
    public int Id { get; set; }

    public int? LecturerId { get; set; }

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual Lecture? Lecturer { get; set; }
}
