namespace DDDSampleProject.Infrastructure.Ef.Models.UserManagement;

public class UserRoleReadModel:BaseReadModel
{
    public Guid UserId { get; set; }
    public UserReadModel User { get; set; }
    public Guid RoleId { get; set; }
    public RoleReadModel Role { get; set; }

}

public class RoleReadModel : BaseReadModel
{
    public string RoleName { get; set; }
    public IReadOnlyList<UserRoleReadModel> UserRoles { get; set; }
}