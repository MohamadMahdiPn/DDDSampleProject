namespace DDDSampleProject.Abstraction.Queries;

public interface IQueryDispacher
{
    Task<TResult> FetchAsync<TResult>(IQuery<TResult> query);
}
