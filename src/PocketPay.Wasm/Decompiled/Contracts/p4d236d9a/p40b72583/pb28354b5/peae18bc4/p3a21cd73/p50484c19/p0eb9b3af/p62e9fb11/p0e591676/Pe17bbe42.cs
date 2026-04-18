namespace WillowMaze.Wasm.Decompiled;

public interface Pe17bbe42
{
    Gson GetGson();
    Certificate[] GetKeyCertificateChain(p30582d95 P0);
    byte[] GetSignatureForJws(string P0, p30582d95 P1);
    bool VerifyJwsSignature(string P0, byte[] P1, RSAPublicKey P2);
}
