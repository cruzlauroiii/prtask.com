namespace WillowMaze.Wasm.Decompiled;

public interface Pd81e8b93
{
    string GetAlgorithmName();
    int GetBlockSize();
    void Init(bool P0, pc9ef6b45 P1);
    int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3);
    void Reset();
}
