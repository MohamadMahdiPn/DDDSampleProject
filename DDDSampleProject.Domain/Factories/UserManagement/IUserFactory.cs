using DDDSampleProject.Domain.Entities.UserManagement;
using DDDSampleProject.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSampleProject.Domain.Factories.UserManagement;

public interface IUserFactory
{
    User Create(BaseId id, UserName userName, Password password, Email email, bool isConfirmed);
}
public class UserFactory : IUserFactory
{
    public User Create(BaseId id, UserName userName, Password password, Email email, bool isConfirmed)
    {
     return new(id, userName, password, email, isConfirmed);
    }
}