namespace DDDSampleProject.Domain.Entitites.UserManagement;

public class Role
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<UserRole> UserRoles { get; set; }


}
