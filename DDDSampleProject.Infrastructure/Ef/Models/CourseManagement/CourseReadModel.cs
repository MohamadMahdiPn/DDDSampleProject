﻿using DDDSampleProject.Infrastructure.Ef.Models.PaymentManagement;

namespace DDDSampleProject.Infrastructure.Ef.Models.CourseManagement;

public class CourseReadModel : BaseReadModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsFree { get; set; }
    public decimal Price { get; set; }
    public Guid InstructorId { get; set; }
    public InstructorReadModel Instructor { get; set; }
    public IReadOnlyList<CourseAttendeeReadModel> CourseAttendees { get; set; }
    public IReadOnlyList<CourseCatalogReadModel> CourseCatalogs { get; set; }
    public IReadOnlyList<InvoiceReadModel> Invoices { get; set; }
}