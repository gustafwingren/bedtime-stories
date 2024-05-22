using Ardalis.Result;
using Ardalis.SharedKernel;

namespace BedtimeStories.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
