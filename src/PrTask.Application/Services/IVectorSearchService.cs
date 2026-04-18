namespace PrTask.Application.Services;
public interface IVectorSearchService
{
    Task IndexAsync(string Id, float[] Embedding);
    Task<IReadOnlyList<string>> SearchAsync(float[] Query, int TopK);
    Task DeleteAsync(string Id);
    Task<long> CountAsync();
}
