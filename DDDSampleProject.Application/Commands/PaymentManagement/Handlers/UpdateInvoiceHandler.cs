using DDDSampleProject.Abstraction.Commands;

namespace DDDSampleProject.Application.Commands.PaymentManagement.Handlers;

public class UpdateInvoiceHandler : ICommandHandler<UpdateInvoice>
{
    public Task HandlerAsync(UpdateInvoice command)
    {
        throw new NotImplementedException();
    }
}