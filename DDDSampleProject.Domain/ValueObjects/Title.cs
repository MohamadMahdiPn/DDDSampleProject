using DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSampleProject.Domain.ValueObjects;

public record Title
{

    #region Constructor
    public Title(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new TitleNullOrEmptyException();
        if (value.Length > 50)
            throw new InvalidTitleLengthException();
        Value = value;
    }
    #endregion

    public string Value { get; }





    public static implicit operator string(Title title) => title.Value;
    public static implicit operator Title(string value) => new Title(value);
}
