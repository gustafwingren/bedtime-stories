using Ardalis.Result;
using Ardalis.SharedKernel;

namespace bedtimestories.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
