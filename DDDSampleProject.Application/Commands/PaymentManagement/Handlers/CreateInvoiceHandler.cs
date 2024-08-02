using DDDSampleProject.Abstraction.Commands;
using DDDSampleProject.Domain.Factories.PaymentManagement;
using DDDSampleProject.Domain.Repositories.PaymentManagement;

namespace DDDSampleProject.Application.Commands.PaymentManagement.Handlers;

public class CreateInvoiceHandler:ICommandHandler<CreateInvoice>
{
    #region Constructor

    private readonly IInvoiceRepository _invoiceRepository;
    private readonly IInvoiceFactory _invoiceFactory;

    public CreateInvoiceHandler(IInvoiceRepository invoiceRepository, IInvoiceFactory invoiceFactory)
    {
        _invoiceRepository = invoiceRepository;
        _invoiceFactory = invoiceFactory;
    }

    #endregion

    public async Task HandlerAsync(CreateInvoice command)
    {
        var invoice = _invoiceFactory.Create(command.id, command.amount, command.date, command.email, command.userId,
            command.courseId);
        await _invoiceRepository.AddAsync(invoice);
    }
}