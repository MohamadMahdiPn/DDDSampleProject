using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDSampleProject.Domain.Primitives;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Entities.UserManagement;

public class User : BaseEntity
{
    #region Constructor

    public User(BaseId id) : base(id)
    {

    }

    internal User(BaseId id, UserName userName, Password password, Email email, bool isConfirmed, string passwordHash) : base(id)
    {
        _userName = userName;
        _password = password;
        _email = email;
        _isConfirmed = isConfirmed;
        _passwordHash = passwordHash;
    }

    #endregion

    private UserName _userName;
    private Password _password;
    private Email _email;
    private bool _isConfirmed;
    private string _passwordHash;
    private LinkedList<UserRole> _userRoles;

}