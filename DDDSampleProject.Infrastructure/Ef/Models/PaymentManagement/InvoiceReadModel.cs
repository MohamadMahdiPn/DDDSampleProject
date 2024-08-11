using DDDSampleProject.Infrastructure.Ef.Models.CourseManagement;
using DDDSampleProject.Infrastructure.Ef.Models.UserManagement;

namespace DDDSampleProject.Infrastructure.Ef.Models.PaymentManagement;

public class InvoiceReadModel : BaseReadModel
{
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public Guid UserId { get; set; }
    public UserReadModel User { get; set; }

    public Guid CourseId { get; set; }
    public CourseReadModel Course { get; set; }

}