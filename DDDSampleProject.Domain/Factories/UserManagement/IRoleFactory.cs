using DDDSampleProject.Domain.Entities.UserManagement;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Factories.UserManagement;

public interface IRoleFactory
{
    Role Create(BaseId id, FullName fullName);
}
public class RoleFactory : IRoleFactory
{
    public Role Create(BaseId id, FullName fullName)
    {
        return new Role(id, fullName);
    }
}