using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDSampleProject.Abstraction.Domain;
using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.Events;
using DDDSampleProject.Domain.Primitives;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Entities.UserManagement;

public class User : AggregateRoot<BaseId>
{
    #region Constructor

    public User()
    {

    }

    internal User(BaseId id, UserName userName, Password password, Email email, bool isConfirmed) 
    {
        Id = id;
        _userName = userName;
        _password = password;
        _email = email;
        _isConfirmed = isConfirmed;
      
        RaiseDomainEvent(new UserRegisteredEvent(this));
    }

    #endregion

    private UserName _userName;
    private Password _password;
    private Email _email;
    private bool _isConfirmed;
    private string _passwordHash;
    private LinkedList<UserRole> _userRoles;
    private LinkedList<CourseAttendee> _courseAttendes;

}