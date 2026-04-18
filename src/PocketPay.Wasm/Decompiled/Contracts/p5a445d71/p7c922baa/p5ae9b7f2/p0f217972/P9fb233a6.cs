namespace WillowMaze.Wasm.Decompiled;

public interface P9fb233a6
{
    int DoFinal(byte[] P0, int P1);
    string GetAlgorithmName();
    byte[] GetMac();
    int GetOutputSize(int P0);
    pd81e8b93 GetUnderlyingCipher();
    int GetUpdateOutputSize(int P0);
    void Init(bool P0, pc9ef6b45 P1);
    void ProcessAADByte(byte P0);
    void ProcessAADBytes(byte[] P0, int P1, int P2);
    int ProcessByte(byte P0, byte[] P1, int P2);
    int ProcessBytes(byte[] P0, int P1, int P2, byte[] P3, int P4);
    void Reset();
}
