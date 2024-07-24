using DDDSampleProject.Domain.Entitites.CourseManagement;
using DDDSampleProject.Domain.Entitites.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSampleProject.Domain.Entitites.PaymentManagement;

public class Invoice
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }

    public Guid CourseId { get; set; }
    public Course Course { get; set; }
}

