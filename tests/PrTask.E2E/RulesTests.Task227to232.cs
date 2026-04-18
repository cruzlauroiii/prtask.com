using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("InferenceEndpoints — completion, embedding, status")]
    public Task InferenceEndpointsCrudAsync()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "InferenceEndpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants.ApiInference)), "InferenceEndpoints mapped at correct route");
        Assert.IsTrue(Source.Contains("SubCompletion"), "Completion endpoint exists");
        Assert.IsTrue(Source.Contains("SubEmbedding"), "Embedding endpoint exists");
        Assert.IsTrue(Source.Contains("SubStatus"), "Status endpoint exists");
        var Interface = ReadSource("PrTask.Application", "Services", "IInferenceService.cs");
        Assert.IsTrue(Interface.Contains("GenerateCompletionAsync"), "Interface has completion");
        Assert.IsTrue(Interface.Contains("GenerateEmbeddingAsync"), "Interface has embedding");
        Assert.IsTrue(Interface.Contains("IsModelLoadedAsync"), "Interface has status");
        return Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("VectorSearchEndpoints — index, query, delete, count")]
    public async Task VectorSearchEndpointsCrudAsync()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "VectorSearchEndpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants.ApiVectorSearch)), "VectorSearchEndpoints mapped");
        Assert.IsTrue(Source.Contains("SubIndex"), "Index endpoint exists");
        Assert.IsTrue(Source.Contains("SubQuery"), "Query endpoint exists");
        Assert.IsTrue(Source.Contains("SubCount"), "Count endpoint exists");
        Assert.IsTrue(Source.Contains("SubVectorById"), "Delete endpoint exists");
        var Interface = ReadSource("PrTask.Application", "Services", "IVectorSearchService.cs");
        Assert.IsTrue(Interface.Contains("IndexAsync"), "Interface has index");
        Assert.IsTrue(Interface.Contains("SearchAsync"), "Interface has search");
        Assert.IsTrue(Interface.Contains("DeleteAsync"), "Interface has delete");
        Assert.IsTrue(Interface.Contains("CountAsync"), "Interface has count");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TranscriptionEndpoints — transcribe, status")]
    public async Task TranscriptionEndpointsCrudAsync()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "TranscriptionEndpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants.ApiTranscription)), "TranscriptionEndpoints mapped");
        Assert.IsTrue(Source.Contains("SubTranscribe"), "Transcribe endpoint exists");
        Assert.IsTrue(Source.Contains("SubStatus"), "Status endpoint exists");
        var Interface = ReadSource("PrTask.Application", "Services", "ITranscriptionService.cs");
        Assert.IsTrue(Interface.Contains("TranscribeAsync"), "Interface has transcribe");
        Assert.IsTrue(Interface.Contains("IsModelLoadedAsync"), "Interface has status");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SyncEndpoints — execute, status, register")]
    public async Task SyncEndpointsCrudAsync()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "SyncEndpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants.ApiSync)), "SyncEndpoints mapped");
        Assert.IsTrue(Source.Contains("SubSyncExecute"), "Execute endpoint exists");
        Assert.IsTrue(Source.Contains("SubStatus"), "Status endpoint exists");
        Assert.IsTrue(Source.Contains("SubSyncRegister"), "Register endpoint exists");
        var Interface = ReadSource("PrTask.Application", "Services", "ISyncService.cs");
        Assert.IsTrue(Interface.Contains("SyncAsync"), "Interface has sync");
        Assert.IsTrue(Interface.Contains("GetSyncStatusAsync"), "Interface has status");
        Assert.IsTrue(Interface.Contains("RegisterChangeAsync"), "Interface has register");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AI client services registered in WASM")]
    public async Task AiClientServicesRegisteredAsync()
    {
        var ClientProgram = ReadSource("PrTask.Client", "Program.cs");
        Assert.IsTrue(ClientProgram.Contains("HttpInferenceService") || ClientProgram.Contains("WssInferenceService"), "Inference client registered");
        Assert.IsTrue(ClientProgram.Contains("HttpVectorSearchService") || ClientProgram.Contains("WssVectorSearchService"), "VectorSearch client registered");
        var InfClient = File.Exists(Path.Combine(SourceRoot, "PrTask.Client", "Services", "WssInferenceService.cs"))
            ? ReadSource("PrTask.Client", "Services", "WssInferenceService.cs")
            : ReadSource("PrTask.Client", "Services", "HttpInferenceService.cs");
        Assert.IsTrue(InfClient.Contains(": IInferenceService"), "Inference client implements interface");
        var InfHttp = File.Exists(Path.Combine(SourceRoot, "PrTask.Client", "Services", "HttpInferenceService.cs"))
            ? ReadSource("PrTask.Client", "Services", "HttpInferenceService.cs") : string.Empty;
        Assert.IsTrue(InfClient.Contains("AiConstants.JsonEmbedding") || InfHttp.Contains("AiConstants.JsonEmbedding"), "Uses AiConstants for JSON");
        var VecClient = File.Exists(Path.Combine(SourceRoot, "PrTask.Client", "Services", "WssVectorSearchService.cs"))
            ? ReadSource("PrTask.Client", "Services", "WssVectorSearchService.cs")
            : ReadSource("PrTask.Client", "Services", "HttpVectorSearchService.cs");
        Assert.IsTrue(VecClient.Contains(": IVectorSearchService"), "VectorSearch client implements interface");
        var VecHttp = File.Exists(Path.Combine(SourceRoot, "PrTask.Client", "Services", "HttpVectorSearchService.cs"))
            ? ReadSource("PrTask.Client", "Services", "HttpVectorSearchService.cs") : string.Empty;
        Assert.IsTrue(VecClient.Contains("AiConstants.JsonResults") || VecHttp.Contains("AiConstants.JsonResults"), "Uses AiConstants for JSON");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AiConstants JSON property names")]
    public async Task AiConstantsJsonPropertiesAsync()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "AiConstants.cs");
        Assert.IsTrue(Source.Contains("JsonEmbedding"), "Has JsonEmbedding");
        Assert.IsTrue(Source.Contains("JsonCompletion"), "Has JsonCompletion");
        Assert.IsTrue(Source.Contains("JsonModelLoaded"), "Has JsonModelLoaded");
        Assert.IsTrue(Source.Contains("JsonResults"), "Has JsonResults");
        Assert.IsTrue(Source.Contains("JsonCount"), "Has JsonCount");
        Assert.IsTrue(Source.Contains("JsonStatus"), "Has JsonStatus");
        Assert.IsTrue(Source.Contains("JsonText"), "Has JsonText");
        await Task.CompletedTask;
    }
}
