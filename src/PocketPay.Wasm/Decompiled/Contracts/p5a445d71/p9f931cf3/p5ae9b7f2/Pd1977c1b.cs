namespace WillowMaze.Wasm.Decompiled;

public interface Pd1977c1b
{
    byte[] GenerateSignature();
    void Init(bool P0, pc9ef6b45 P1);
    void Reset();
    void Update(byte P0);
    void Update(byte[] P0, int P1, int P2);
    bool VerifySignature(byte[] P0);
}
