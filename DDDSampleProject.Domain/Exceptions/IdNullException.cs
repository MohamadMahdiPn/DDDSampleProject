using DDDSampleProject.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSampleProject.Domain.Exceptions;

internal class IdNullException:CourseManagementException
{
	public IdNullException():base("Id Can not be null !!!")
	{

	}
}

