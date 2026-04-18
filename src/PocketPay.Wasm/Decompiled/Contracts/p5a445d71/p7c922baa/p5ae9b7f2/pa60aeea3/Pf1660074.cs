namespace WillowMaze.Wasm.Decompiled;

public interface Pf1660074
{
    byte[] ExportKeyingMaterial(string P0, byte[] P1, int P2);
    pb2a46d81 GetClientVersion();
    p1d0e61fd GetNonceRandomGenerator();
    pfc4c6ea5 GetResumableSession();
    System.Security.Cryptography.RandomNumberGenerator GetSecureRandom();
    p937e6f23 GetSecurityParameters();
    pb2a46d81 GetServerVersion();
    object GetUserObject();
    bool IsServer();
    void SetUserObject(object P0);
}
