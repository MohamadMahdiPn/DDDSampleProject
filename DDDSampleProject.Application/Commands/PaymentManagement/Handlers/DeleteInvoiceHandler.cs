using DDDSampleProject.Abstraction.Commands;

namespace DDDSampleProject.Application.Commands.PaymentManagement.Handlers;

public class DeleteInvoiceHandler : ICommandHandler<DeleteInvoice>
{
    public Task HandlerAsync(DeleteInvoice command)
    {
        throw new NotImplementedException();
    }
}