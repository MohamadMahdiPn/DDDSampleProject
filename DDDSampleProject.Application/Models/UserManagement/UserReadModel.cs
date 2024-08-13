using DDDSampleProject.Application.Models.CourseManagement;
using DDDSampleProject.Application.Models.PaymentManagement;

namespace DDDSampleProject.Application.Models.UserManagement;

public class UserReadModel : BaseReadModel
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public bool IsConfirmed { get; set; }

    public IReadOnlyList<CourseAttendeeReadModel> CourseAttendees { get; set; }
    public IReadOnlyList<UserRoleReadModel> UserRoles { get; set; }
    public IReadOnlyList<InvoiceReadModel> Invoices { get; set; }
}