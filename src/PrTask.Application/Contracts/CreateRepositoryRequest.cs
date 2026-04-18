using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record CreateRepositoryRequest(string OwnerId, string Url, string? Name, RepositoryVisibility Visibility);
