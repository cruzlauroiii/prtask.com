namespace WillowMaze.Wasm.Decompiled;

public interface P748b767e_p244f52bf
{
    void Complete();
    void Error(Exception P0);
    Exception GetError();
    object GetValue();
    object[] GetValues(object[] P0);
    bool IsDone();
    void Next(object P0);
    void Replay(p748b767e$pa01d495c P0);
    int Size();
    void TrimHead();
}
