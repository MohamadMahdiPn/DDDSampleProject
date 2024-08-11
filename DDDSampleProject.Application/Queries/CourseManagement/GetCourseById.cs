﻿using DDDSampleProject.Abstraction.Queries;
using DDDSampleProject.Application.Dtos;

namespace DDDSampleProject.Application.Queries.CourseManagement;

public class GetCourseById:IQuery<CourseDto>
{
    public Guid CourseId { get; set; }

}