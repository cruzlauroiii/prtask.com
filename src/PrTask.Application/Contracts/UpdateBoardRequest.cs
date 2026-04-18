using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record UpdateBoardRequest(string Name, BoardType Type, string? SprintId);
