namespace WillowMaze.Wasm.Decompiled;

public interface Pbd7aaca5
{
    void Init(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1, byte[] P2);
    void Init(System.Numerics.BigInteger P0, System.Security.Cryptography.RandomNumberGenerator P1);
    bool IsDeterministic();
    System.Numerics.BigInteger NextK();
}
