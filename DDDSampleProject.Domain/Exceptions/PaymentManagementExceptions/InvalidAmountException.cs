using DDDSampleProject.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSampleProject.Domain.Exceptions.PaymentManagementExceptions
{
    internal class InvalidAmountException: PaymentManagementException
    {
        public InvalidAmountException():base("Amount is invalid !!!")
        {

        }
    }
}
