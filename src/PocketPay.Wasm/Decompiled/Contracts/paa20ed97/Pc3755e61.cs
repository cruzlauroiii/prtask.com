namespace WillowMaze.Wasm.Decompiled;

public interface Pc3755e61
{
    void Cancel();
    pc3755e61 Clone();
    void Enqueue(p406c70d6 P0);
    Response Execute();
    bool IsCanceled();
    bool IsExecuted();
    p15c2d85f Request();
    pc85a251c Timeout();
}
