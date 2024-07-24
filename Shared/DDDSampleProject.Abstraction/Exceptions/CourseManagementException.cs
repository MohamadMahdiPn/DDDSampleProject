using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSampleProject.Abstraction.Exceptions;

public abstract class CourseManagementException : Exception
{
    protected CourseManagementException(string message) : base(message) 
    {

    }
}


