using DDDSampleProject.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSampleProject.Domain.ValueObjects;

public record BaseId
{
    #region Constructor
    public BaseId(Guid value)
    {
        if (value == Guid.Empty)
            throw new IdNullException();
        Value = value;
    }
    #endregion


    public Guid Value { get; }



    public static implicit operator Guid(BaseId id) => id.Value;
    public static implicit operator BaseId(Guid id) => new BaseId(id);


}

