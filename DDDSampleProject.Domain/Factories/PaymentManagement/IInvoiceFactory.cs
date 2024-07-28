using DDDSampleProject.Domain.Entities.PaymentManagement;
using DDDSampleProject.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSampleProject.Domain.Factories.PaymentManagement;

public interface IInvoiceFactory
{
    Invoice Create(BaseId id, Amount amount, DateTime date, Email email, BaseId userId, BaseId courseId);
}
public class InvoiceFactory : IInvoiceFactory
{
    public Invoice Create(BaseId id, Amount amount, DateTime date, Email email, BaseId userId, BaseId courseId)
    {
        return new(id, amount, date, email, userId, courseId);
    }
}
