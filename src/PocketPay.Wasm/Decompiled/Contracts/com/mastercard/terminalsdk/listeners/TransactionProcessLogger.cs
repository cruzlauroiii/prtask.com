namespace WillowMaze.Wasm.Decompiled;

public interface TransactionProcessLogger
{
    void LogApduExchange(string P0);
    void LogCryptoOperations(string P0);
    void LogDebug(string P0);
    void LogError(string P0);
    void LogInfo(string P0);
    void LogInternalOperation(string P0);
    void LogStage(string P0);
    void LogTlvParsing(string P0);
    void LogVerbose(string P0);
    void LogWarning(string P0);
}
