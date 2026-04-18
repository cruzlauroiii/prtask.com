namespace PrTask.Llama;

public static class LlamaConstants
{
    public const uint DefaultBatchSize = 2048;
    public const int AutoThreads = -1;
    public const int LastOutput = -1;
    public const uint DefaultSeed = 0xFFFFFFFF;
    public const int DefaultPenaltyLastN = 64;
    public const float DefaultRepeatPenalty = 1.1f;
    public const int ModelDescBufferSize = 256;
    public const int MetadataBufferSize = 512;
    public const int TokenTextBufferSize = 128;
    internal const string ErrorModelLoad = "Failed to load model from specified path.";
    internal const string ErrorContextCreate = "Failed to create llama context.";
    internal const string ErrorSamplerChainCreate = "Failed to create sampler chain.";
    internal const string ErrorTokenization = "Tokenization failed.";
}
