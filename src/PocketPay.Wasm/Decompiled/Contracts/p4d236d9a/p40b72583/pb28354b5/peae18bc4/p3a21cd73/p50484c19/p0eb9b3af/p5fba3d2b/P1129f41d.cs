namespace WillowMaze.Wasm.Decompiled;

public interface P1129f41d
{
    p1129f41d M8bab0102();
    int CheckStoreAuthentic(int P0);
    void ClearStore();
    void DeleteEntry(p30582d95 P0);
    void GenerateKeyPair(p30582d95 P0, byte[] P1);
    Certificate[] GetKeyCertificateChain(p30582d95 P0);
    SecretKey GetOrGenerateSecretKey(p30582d95 P0);
    PrivateKey GetPrivateKey(p30582d95 P0);
}
