namespace PrTask.Application.Contracts;
public record CreateBoardColumnRequest(string BoardId, string Name, int Order, int? WipLimit);
