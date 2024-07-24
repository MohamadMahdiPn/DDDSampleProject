using DDDSampleProject.Domain.Primitives;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Entities.UserManagement;

public class Role:BaseEntity
{
    #region Constructor


    public Role(BaseId id):base(id)
    {
        
    }

    internal Role(BaseId id, FullName fullName) : base(id)
    {
        _fullName = fullName;
        
    }

    #endregion
    private FullName _fullName;
   private LinkedList<UserRole> _userRoles;
  


}
