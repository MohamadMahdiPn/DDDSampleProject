﻿using DDDSampleProject.Abstraction.Exceptions;

namespace DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidPriceException : CourseManagementException
{
    public InvalidPriceException() : base("Price can not be less than 0 ")
    {

    }
}

