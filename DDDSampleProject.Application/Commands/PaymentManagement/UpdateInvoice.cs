using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Application.Commands.PaymentManagement;

public record UpdateInvoice(BaseId id, Amount amount, DateTime date, Email email, BaseId userId, BaseId courseId) : ICommand;