namespace WillowMaze.Wasm.Decompiled;

public interface Pe5cfc515
{
    int DoFinal(byte[] P0, int P1);
    string GetAlgorithmName();
    int GetDigestSize();
    void Reset();
    void Update(byte P0);
    void Update(byte[] P0, int P1, int P2);
}
