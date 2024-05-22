using Ardalis.Result;
using Ardalis.SharedKernel;

namespace BedtimeStories.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
