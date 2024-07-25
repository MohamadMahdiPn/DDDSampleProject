using DDDSampleProject.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class BiographyNullOrEmptyException : CourseManagementException
{
    public BiographyNullOrEmptyException() : base("biography can not be empty !!!")
    {

    }
}

