using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Primitives;

public class BaseEntity
{
    protected BaseEntity(BaseId id)
    {
        Id = id;
    }
    public BaseId Id { get; private set; }
}