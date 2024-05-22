using Ardalis.Result;
using Ardalis.SharedKernel;

namespace BedtimeStories.UseCases.Contributors.Update;

public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
