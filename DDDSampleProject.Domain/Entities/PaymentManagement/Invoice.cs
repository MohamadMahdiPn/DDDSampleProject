using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.Entities.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDSampleProject.Domain.Primitives;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Entities.PaymentManagement;

public class Invoice:BaseEntity
{
    #region Constructor

    public Invoice(BaseId id):base(id)
    {
        
    }

    internal Invoice(BaseId id, Amount amount, DateTime date, Email email, BaseId userId, BaseId courseId) 
        : base(id)
    {
        _amount = amount;
        _date = date;
        _email = email;
        _userId = userId;
        _courseId = courseId;
    }

    #endregion

    private Amount _amount;
    private DateTime _date;
    private Email _email;
    private BaseId _userId;
    private BaseId _courseId;

}

