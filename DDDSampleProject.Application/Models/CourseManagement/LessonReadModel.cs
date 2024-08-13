﻿namespace DDDSampleProject.Application.Models.CourseManagement;

public class LessonReadModel:BaseReadModel
{
    public string Title { get; set; }
    public string VideoUrl { get; set; }
    public Guid CourseCatalogId { get; set; }
    public CourseCatalogReadModel CourseCatalog { get; set; }
}