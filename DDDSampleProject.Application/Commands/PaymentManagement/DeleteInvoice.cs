using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Application.Commands.PaymentManagement;

public record DeleteInvoice(BaseId id):ICommand;