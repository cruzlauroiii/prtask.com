namespace WillowMaze.Wasm.Decompiled;

public interface P8acc0558
{
    string GetNonce();
    string GetRuntimeCheck();
    void SetNonce(string P0);
    Completable StartCheck();
    Completable StopCheck();
}
