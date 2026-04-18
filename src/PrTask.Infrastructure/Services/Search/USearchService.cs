using System.Collections.Concurrent;
using PrTask.Application.Services;
namespace PrTask.Infrastructure.Services.Search;
public sealed class USearchService : IVectorSearchService
{
    private readonly ConcurrentDictionary<string, float[]> Vectors = new();
    public Task IndexAsync(string Id, float[] Embedding)
    {
        Vectors[Id] = Embedding;
        return Task.CompletedTask;
    }
    public Task<IReadOnlyList<string>> SearchAsync(float[] Query, int TopK)
    {
        if (Vectors.IsEmpty) { return Task.FromResult<IReadOnlyList<string>>([]); }
        var Scored = new List<(string Id, float Score)>(Vectors.Count);
        foreach (var Pair in Vectors)
        {
            Scored.Add((Pair.Key, CosineSimilarity(Query, Pair.Value)));
        }
        Scored.Sort((A, B) => B.Score.CompareTo(A.Score));
        var Count = Math.Min(TopK, Scored.Count);
        var Results = new List<string>(Count);
        for (var I = 0; I < Count; I++) { Results.Add(Scored[I].Id); }
        return Task.FromResult<IReadOnlyList<string>>(Results);
    }
    public Task DeleteAsync(string Id)
    {
        Vectors.TryRemove(Id, out _);
        return Task.CompletedTask;
    }
    public Task<long> CountAsync() => Task.FromResult((long)Vectors.Count);
    private static float CosineSimilarity(float[] A, float[] B)
    {
        var Length = Math.Min(A.Length, B.Length);
        var Dot = 0f;
        var NormA = 0f;
        var NormB = 0f;
        for (var I = 0; I < Length; I++)
        {
            Dot += A[I] * B[I];
            NormA += A[I] * A[I];
            NormB += B[I] * B[I];
        }
        var Denominator = MathF.Sqrt(NormA) * MathF.Sqrt(NormB);
        return Denominator < float.Epsilon ? 0f : Dot / Denominator;
    }
}
