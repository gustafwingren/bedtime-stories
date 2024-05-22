using Ardalis.Result;
using Ardalis.SharedKernel;

namespace bedtimestories.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
