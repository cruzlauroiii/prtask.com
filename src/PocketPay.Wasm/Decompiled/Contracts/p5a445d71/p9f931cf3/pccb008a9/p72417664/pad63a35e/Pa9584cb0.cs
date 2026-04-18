namespace WillowMaze.Wasm.Decompiled;

public interface Pa9584cb0
{
    string GetAlgorithm();
    PrivateKey GetUpdatedPrivateKey();
    void InitSign(PrivateKey P0);
    void InitSign(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1);
    void InitVerify(PublicKey P0);
    void InitVerify(Certificate P0);
    bool IsSigningCapable();
    int Sign(byte[] P0, int P1, int P2);
    byte[] Sign();
    void Update(byte P0);
    void Update(byte[] P0);
    void Update(byte[] P0, int P1, int P2);
    bool Verify(byte[] P0);
    bool Verify(byte[] P0, int P1, int P2);
}
