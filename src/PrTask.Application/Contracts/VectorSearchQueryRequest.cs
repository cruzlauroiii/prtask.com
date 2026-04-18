namespace PrTask.Application.Contracts;
public record VectorSearchQueryRequest(float[] Query, int TopK);
