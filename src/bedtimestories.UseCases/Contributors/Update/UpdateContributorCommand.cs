using Ardalis.Result;
using Ardalis.SharedKernel;

namespace bedtimestories.UseCases.Contributors.Update;

public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
