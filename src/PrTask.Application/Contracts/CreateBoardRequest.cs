using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record CreateBoardRequest(string Name, string OwnerId, BoardType Type, string? SprintId);
