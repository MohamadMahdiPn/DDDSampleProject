﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSampleProject.Abstraction.Domain;

public abstract class AggregateRoot<T>
{
    public T Id { get; protected set; }
    public int Version { get;protected set; }
    private bool _isIncremented;
    protected void IncrementVersion()
    {
        if (_isIncremented)
            return;
        Version++;
        _isIncremented = true;

    }
}
